using Nanook.QueenBee.Parser;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace QDB
{
    public struct ScriptEntity
    {
        // this will probably be hard to use since the script still
        // might be compressed in memory even when its ran by
        // qbstruct::run
        public byte  [] code;
        public uint  [] ips;
        public string[] src;
        public string   name;
        public bool  [] extraline;
    }

    public partial class dbUI : Form
    {
        MemoryMappedFile MultimediaFusion;
        const uint MMFsz = 0x10000;
        ProcessStartInfo GH3PSI = new ProcessStartInfo();
        Process GH3;
        bool GH3R = false; // running
        bool GH3L = false; // loaded

        PakFormat QBLoader;
        PakEditor QBEditor, DBGFiles;
        string exeroot, pakf;
        string root;

        bool[] brkpnts;
        Dictionary<uint,string> Names = new Dictionary<uint,string>();
        List<ScriptEntity> Scripts = new List<ScriptEntity>();
        int currentLoadedScript;

        int currentRunningScript = 0x7FFFFFFF;

        MemoryMappedViewAccessor DebugData;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        public dbUI(string[] args)
        {
            InitializeComponent();
            try
            {
                MultimediaFusion = MemoryMappedFile.CreateOrOpen("GH3_QDebug_DTA", MMFsz);
                DebugData = MultimediaFusion.CreateViewAccessor(0, 0x10000);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            if (args.Length > 0)
                if (File.Exists(args[0]))
                {
                    LoadData(args[0]);
                }
            try {
                if (Directory.Exists(Path.GetDirectoryName(Environment.GetCommandLineArgs()[0])))
                    root = (Path.GetDirectoryName(Environment.GetCommandLineArgs()[0])) + '\\';
                else
                    root = Directory.GetCurrentDirectory() + '\\';
            }
            catch { }
        }

        private string loadDbgQBFile(string qbFilename)
        {
            string dbgFilename = qbFilename.Replace(string.Format(".qb.{0}", QBLoader.FileExtension), string.Format(".{0}", QBLoader.QbDebugExtension));

            string key = null;

            try
            {
                if (DBGFiles != null)
                {
                    if (DBGFiles.Headers.ContainsKey(dbgFilename.ToLower()))
                        key = dbgFilename.ToLower();
                    else
                    {
                        dbgFilename = qbFilename.Replace(string.Format(".qb.{0}", QBLoader.FileExtension), string.Format(".{0}.{1}", QBLoader.QbDebugExtension, QBLoader.FileExtension));

                        if (DBGFiles.Headers.ContainsKey(dbgFilename.ToLower()))
                            key = dbgFilename.ToLower();
                        else
                        {
                            //use the qb pak headers to lookup the debugQbKeys.
                            //the debug pak has QBKeys as the keys instead of filenames
                            foreach (PakHeaderItem phi in QBEditor.Headers.Values)
                            {
                                if (phi.Filename.ToLower() == qbFilename)
                                {
                                    key = phi.DebugQbKey.ToString("X").PadLeft(8, '0').ToLower();
                                    break;
                                }
                            }
                        }
                    }

                    if (key != null && DBGFiles != null && DBGFiles.Headers.ContainsKey(key))
                        return DBGFiles.ExtractFileToString(key);
                }
            }
            catch
            {
            }
            return string.Empty;
        }
        private void parseDbg(string text)
        {
            // thief!
            // i dont use dictionaries
            {
                string[] d = text.Replace("\r", "").Split(new char[] { '\n' });

                bool b = false;
                int pos = 10;
                foreach (string s in d)
                {
                    if (b)
                    {
                        if (s.Trim().Length > 2)
                        {
                            if (s[pos] == ' ')
                                try {
                                    Names.Add(uint.Parse(s.Substring(2, pos - 2), System.Globalization.NumberStyles.HexNumber), s.Substring(pos + 1));
                                }
                                catch { }
                            else
                                throw new ApplicationException(string.Format("Bad Entry in checksum in debug file, char[{0}] id not a space", pos.ToString()));
                        }

                    }
                    else
                    {
                        if (s == "[Checksums]")
                            b = true;
                    }
                }
            }
        }

        void LoadData(string exepath)
        {
            exeroot = Path.GetDirectoryName(Path.GetFullPath(exepath)) + '\\';
            pakf = exeroot + "\\DATA\\PAK\\";
            QBLoader = new PakFormat(
                pakf + "qb.pak.xen",
                pakf + "qb.pab.xen",
                pakf + "dbg.pak.xen", PakFormatType.PC);
            GH3PSI.FileName = Path.GetFullPath(exepath);
            GH3PSI.WorkingDirectory = exeroot;
            bool debugPak = QBLoader.DebugFileExists;
            QBEditor = new PakEditor(QBLoader, false);
            DBGFiles = new PakEditor(QBLoader, true);
            QbFile curQbFile;
            Scripts.Clear();
            scriptsListWBrkpnts.Items.Clear();
            foreach (string file in QBEditor.QbFilenames)
            {
                try {
                    curQbFile = QBEditor.ReadQbFile(file, loadDbgQBFile(file));
                    parseDbg(loadDbgQBFile(file));
                    for (int i = 0; i < curQbFile.Items.Count; i++)
                    {
                        if (curQbFile.Items[i].QbItemType == QbItemType.SectionScript)
                        {
                            QbItemScript testScr = (QbItemScript)curQbFile.Items[i];
                            ScriptEntity newScrEnt = new ScriptEntity();
                            newScrEnt.code = testScr.ScriptData;
                            if (testScr.DebugName != "")
                                newScrEnt.name = testScr.DebugName;
                            else
                                newScrEnt.name = testScr.ItemQbKey.Crc.ToString("X8");
                            string[] tmpSrc = testScr.Translate(Names).Split('\n');
                            newScrEnt.ips = new uint[tmpSrc.Length];
                            newScrEnt.src = new string[tmpSrc.Length];
                            newScrEnt.extraline = new bool[tmpSrc.Length];
                            uint j = 0;
                            foreach (string line in tmpSrc)
                            {
                                try
                                {
                                    newScrEnt.ips[j] = uint.Parse(line.Substring(0, 4), System.Globalization.NumberStyles.HexNumber);
                                    newScrEnt.src[j] = line.Substring(5);
                                }
                                catch
                                {
                                    if (j != 0)
                                        newScrEnt.ips[j] = newScrEnt.ips[j - 1];
                                    newScrEnt.src[j] = '\t' + line;
                                    newScrEnt.extraline[j] = true;
                                }
                                j++;
                            }
                            Scripts.Add(newScrEnt);
                            scriptsListWBrkpnts.Items.Add(newScrEnt.name);
                        }
                    }
                } catch { }
            }
            brkpnts = new bool[Scripts.Count];
            runGameBtn.Enabled = true;
            testCodeList.Enabled = true;
            GH3L = true;
            GC.Collect();
        }

        void gameShutdown()
        {
            GH3R = false;
            autostepBtn.Enabled = false;
            ACEbtn.Enabled = false;
            pauseGameBtn.Enabled = false;
            stopGameBtn.Enabled = false;
            restartGameBtn.Enabled = false;
            stepCodeBtn.Enabled = false;
            stepOvBtn.Enabled = false;
            CSDlabel.Enabled = false;
            scriptNameAndGoto.Enabled = false;
            ScrIPlbl.Enabled = false;
            curScrCont.Enabled = false;
            curScrStructPanel.Enabled = false;
            if (GH3.ExitCode > 0)
                MessageBox.Show("Guitar Hero exited with a non-zero error code.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            GC.Collect();
            Thread.Sleep(1500);
            try
            {
                File.Delete(exeroot + "\\PLUGINS\\QDBhook.dll");
                Thread.Sleep(400);
            }
            catch
            {
                try
                {
                    File.Delete(exeroot + "\\PLUGINS\\QDBhook.dll");
                    Thread.Sleep(400);
                }
                catch
                {

                }
            }
        }


        public void gameExited(object sender, EventArgs e)
        {
            //ReadCSD();
            gameShutdown();
        }

        enum GameState : byte // byte 0 of MMF
        {
            Running = 0x00,
            Pause   = 0xF0,
            Step    = 0xF2,
            StepOver= 0xF2 | 1
        }

        void StartOrUnpauseGame()
        {
            if (!GH3R)
            {

                File.Copy(
                    root + "\\QDBhook.dll",
                    exeroot + "\\PLUGINS\\QDBhook.dll", true);
                GH3 = new Process();
                GH3.StartInfo = GH3PSI;
                GH3.Start();
                GH3.EnableRaisingEvents = true;
                GH3.Exited += new EventHandler(gameExited);
                pauseGameBtn.Enabled = true;
                stopGameBtn.Enabled = true;
                restartGameBtn.Enabled = true;
                stepCodeBtn.Enabled = true;
                stepOvBtn.Enabled = true;
                CSDlabel.Enabled = true;
                scriptNameAndGoto.Enabled = true;
                ScrIPlbl.Enabled = true;
                curScrCont.Enabled = true;
                curScrStructPanel.Enabled = true;
                autostepBtn.Enabled = true;
                ACEbtn.Enabled = true;
                GH3R = true;
                RTValuesTicker.Start();
            }
            else
                DebugData.Write(0, (byte)GameState.Running);
                    //              ^ wtf
        }
        void Suspend()
        {
            if (!GH3.HasExited)
            {
                DebugData.Write(0, (byte)GameState.Pause);
                ReadCSD();
            }
        }

        private void RunClick(object sender, EventArgs e)
        {
            StartOrUnpauseGame();
        }

        void addStructToCSD(uint counter, uint entries)
        {
            uint entryIndex = entries;
            curScrStructs.BeginUpdate();
            for (uint i = 0; i < DebugData.ReadUInt32(counter); i++)
            {
                uint key = 0, value = 0;
                byte type = 0, indent = 0;
                try {
                    key = DebugData.ReadUInt32(entryIndex);
                } catch { MessageBox.Show("2", "CHECK SOURCE FOR WHERE THIS FAILED"); }
                // totally safe to continue running after these catches execute
                try {
                    value = DebugData.ReadUInt32(entryIndex + 4);
                } catch { MessageBox.Show("3", "CHECK SOURCE FOR WHERE THIS FAILED"); }
                try {
                    type = DebugData.ReadByte(entryIndex + 8);
                } catch { MessageBox.Show("4", "CHECK SOURCE FOR WHERE THIS FAILED"); }
                try {
                    indent = DebugData.ReadByte(entryIndex + 9);
                } catch { MessageBox.Show("5", "CHECK SOURCE FOR WHERE THIS FAILED"); }
                string valuestr = value.ToString();
                string keystr;
                try { keystr = Names[key]; }
                catch { keystr = key.ToString("X8"); }
                TreeNode itemNode = new TreeNode("", 0, 0);
                ListViewItem listItem = new ListViewItem();
                int itemIcon = 8;
                switch (type)
                {
                    case 1:
                        itemIcon = 2;
                        valuestr = ((int)value).ToString();
                        break;
                    case 2:
                        valuestr = DebugData.ReadSingle(entryIndex + 4).ToString();
                        itemIcon = 1;
                        break;
                    case 3:
                        // assuming SZ type string
                        // despite guessing that queenbee can store zeroes in strings

                        // WHAT?! v
                        ushort len2 = DebugData.ReadUInt16(entryIndex + 4);
                        ushort ptr2 = DebugData.ReadUInt16(entryIndex + 6);
                        byte[] strbytes = new byte[len2];
                        DebugData.ReadArray(ptr2, strbytes, 0, len2);
                        valuestr = System.Text.Encoding.ASCII.GetString(strbytes);
                        valuestr = valuestr.Substring(0, Math.Min(valuestr.Length, len2));
                        itemIcon = 5;
                        break;
                    case 4:
                        // WHY?!  v
                        ushort len3 = DebugData.ReadUInt16(entryIndex + 4);
                        ushort ptr3 = DebugData.ReadUInt16(entryIndex + 6);
                        byte[] wstrbytes = new byte[len3];
                        DebugData.ReadArray(ptr3, wstrbytes, 0, len3);
                        valuestr = System.Text.Encoding.Unicode.GetString(wstrbytes);
                        valuestr = valuestr.Substring(0, Math.Min(valuestr.Length, len3));
                        itemIcon = 5;
                        break;
                    case 5:
                    case 6:
                    case 0xC:
                        valuestr = "";
                        itemIcon = 0;
                        break;
                    case 0xA:
                        valuestr = "";
                        itemIcon = 6;
                        break;
                    case 0xD:
                        try { // should make this part a function
                            valuestr = Names[value];
                        } catch {
                            valuestr = value.ToString("X8");
                        }
                        itemIcon = 3;
                        break;
                    case 0x1A:
                        string addr;
                        try {
                            addr = Names[value];
                        } catch {
                            addr = value.ToString("X8");
                        }
                        valuestr = "*";
                        itemIcon = 14;
                        break;
                }
                listItem.Text = keystr;
                listItem.ImageIndex = itemIcon;
                listItem.IndentCount = indent;
                listItem.SubItems.Add(valuestr);
                listItem.ToolTipText = valuestr;
                curScrStructs.Items.Add(listItem);
                entryIndex += 0x10;
            }
            curScrStructs.EndUpdate();
        }

        // WHY WON'T THIS WORK IN SOME WAY AFTER STOPPING THE GAME
        // AND WHY IS IT THROWING ERRORS
        void ReadCSD()
        {
            if (!GH3.HasExited && GH3L && GH3R)
            {
                try
                {
                    scriptNameAndGoto.Text = Names[DebugData.ReadUInt32(0x10)];
                }
                catch
                {
                    scriptNameAndGoto.Text = DebugData.ReadUInt32(0x10).ToString("X8");
                }
                try {
                    ScrIPlbl.Text = DebugData.ReadUInt32(0x14).ToString("X8");
                }
                catch { MessageBox.Show("1"); }
                curScrStructs.Items.Clear();
                curScrStructs.Items.Add("QbStruct (0x14)", 6);
                addStructToCSD(0x1C, 0x20);
                curScrStructs.Items.Add("QbStruct (0x1C)", 6);
                addStructToCSD(0x1FFC, 0x2000);
                
                scrStackLbl.Text = DebugData.ReadUInt32(0xA000 - 4).ToString("X8");

                scriptStack.Items.Clear();
                string scriptStackName;
                uint stackSize = DebugData.ReadUInt32(0xA000-4);
                ListViewItem stackItem;
                string[] stackStrings;
                for (int i = 0; i < stackSize; i++)
                {
                    try {
                        scriptStackName = Names[DebugData.ReadUInt32(0xA000 + (i << 2))];
                    } catch {
                        scriptStackName = DebugData.ReadUInt32(0xA000 + (i << 2)).ToString("X8");
                    }
                    scriptStackName = DebugData.ReadUInt32(0xA000 + (i << 2)).ToString("X8");
                    stackStrings = new string[2] {
                        scriptStackName,
                        DebugData.ReadUInt32(0xB000 + (i << 2)).ToString("X8")
                    };
                    stackItem = new ListViewItem(stackStrings);
                    scriptStack.Items.Add(stackItem);
                }
                string tmp = "";
                for (int i = 0; i < 4; i++)
                {
                    tmp += DebugData.ReadUInt32(0x500 + (i << 2)).ToString("X8") + ' ';
                }
                tmp += '\n' + DebugData.ReadUInt32(0x518).ToString("X8") + '\n';
                for (int i = 0; i < 4 * 12; i++)
                {
                    tmp += DebugData.ReadUInt32(0x520 + (i << 2)).ToString("X8") + ' ';
                    if (i % 4 == 3)
                        tmp += '\n';
                }
                CSDflags.Text = tmp;
                QbKey newScr = QbKey.Create(scriptNameAndGoto.Text);
                if (currentRunningScript != 0x7FFFFFFF && currentRunningScript == scriptsListWBrkpnts.FindItemWithText(scriptNameAndGoto.Text).Index)
                {
                    scriptsListWBrkpnts.Items[currentRunningScript].StateImageIndex = 0;
                    scriptsListWBrkpnts.FindItemWithText(scriptNameAndGoto.Text).StateImageIndex = 2;
                    currentRunningScript = scriptsListWBrkpnts.FindItemWithText(scriptNameAndGoto.Text).Index;
                }
            }
        }

        private void CSDgotoScript(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (scriptsListWBrkpnts.SelectedItems.Count > 0)
            {
                ListViewItem selected = scriptsListWBrkpnts.SelectedItems[0];
                int index = scriptsListWBrkpnts.Items.IndexOf(selected);
                if (index == -1)
                    return;
                scriptsListWBrkpnts.SelectedIndices.Clear();
                scriptsListWBrkpnts.SelectedIndices.Add(index);
                scriptsListWBrkpnts.TopItem = scriptsListWBrkpnts.Items[index];
                loadScriptCode(index);
            }
        }

        private void pauseGameBtn_Click(object sender, EventArgs e)
        {
            DebugData.Write(2, (byte)1);
            Suspend();
        }

        private void stopGameBtn_Click(object sender, EventArgs e)
        {
            ReadCSD();
            if (!GH3.HasExited)
                GH3.Kill();
        }

        private void stepCodeBtn_Click(object sender, EventArgs e)
        {
            if (!GH3.HasExited)
            {
                DebugData.Write(0, (byte)GameState.Step);
                ReadCSD();
            }
        }

        private void stepOvBtn_Click(object sender, EventArgs e)
        {
            if (!GH3.HasExited)
            {
                DebugData.Write(0, (byte)GameState.StepOver);
                ReadCSD();
            }
        }

        private void Exiting(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill(); // takes a while to exit because of ListView???
            //scriptsList.Items.Clear();
            //GC.Collect();
        }
        private void RTValuesTicker_Tick(object sender, EventArgs e)
        {
            if (DebugData.ReadByte(1) == 1)
            {
                ReadCSD();
                //autostepBtn.Checked = false;
                DebugData.Write(1, (byte)0);
                SetForegroundWindow(Handle);
            }
            else
            {
                if (autostepBtn.Checked)
                {
                    if (!GH3.HasExited)
                    {
                        DebugData.Write(0, (byte)GameState.Step);
                        ReadCSD();
                    }
                }
            }
            if (autoupdCSD.Checked)
            {
                if (!GH3.HasExited)
                {
                    ReadCSD();
                }
            }
            //if (GH3R)
                //MessageBox.Show(DebugData.ReadByte(5).ToString());
            //ReadCSD();
        }

        void loadScriptCode(int index)
        {
            currentLoadedScript = index;
            testCodeList.Rows.Clear();
            for (int i = 0; i < Scripts[index].src.Length; i++)
            {
                Bitmap test0 = Properties.Resources.blank, test1 = Properties.Resources.blank;
                // when IP matches a line, test1 = Properties.Resources.RightArrowHS
                // IMPLEMENT WHEN IP ADJUSTMENT STUFF IS FIXED
                //if (Scripts[index].brkpnt[i])
                    //test0 = Properties.Resources.RecordHS;
                try {
                    if (!Scripts[index].extraline[i])
                        testCodeList.Rows.Add(test0, test1,
                            Scripts[index].ips[i].ToString("X4"), Scripts[index].src[i]);
                    else
                        testCodeList.Rows.Add(test0, test1,
                            "", Scripts[index].src[i]);
                } catch { }
            }
        }

        private void qbKeyEvalBtn_Click(object sender, EventArgs e)
        {
            new QbKeyTest(Names).ShowDialog();
        }

        private void runScriptDiag(object sender, EventArgs e)
        {
            ACEDiag test = new ACEDiag();
            if (test.ShowDialog() == DialogResult.OK)
            {
                DebugData.Write(0xE9F7, test.paramTypes.Length);
                DebugData.Write(0xE9FB, (byte)1);
                DebugData.Write(0xE9FC, test.scrKey.Crc);
                int off = 0xEA00;
                int dynaval = 0xEC00;
                for (int i = 0; i < test.paramTypes.Length && i < 16; i++)
                {
                    byte itemType = 0;
                    DebugData.Write(off + 0x0, test.paramKeys[i].Crc);
                    //MessageBox.Show(test.paramTypes[i]);
                    switch (test.paramTypes[i])
                    {
                        case "Int":
                            itemType = 1;
                            int test2 = 0;
                            int.TryParse(test.paramVals[i], out test2);
                            DebugData.Write(off + 0x4, test2);
                            break;
                        case "Float":
                            itemType = 2;
                            float test3 = 0.0f;
                            float.TryParse(test.paramVals[i], out test3);
                            DebugData.Write(off + 0x4, test3);
                            break;
                        case "QbKey":
                            itemType = 13;
                            DebugData.Write(off + 0x4, QbKey.Create(test.paramVals[i]).Crc);
                            break;
                        case "String":
                            itemType = 3;
                            DebugData.Write(off + 0x4, dynaval);
                            string test4 = test.paramVals[i];
                            for (int j = 0; j < test4.Length; j++)
                            {
                                DebugData.Write(dynaval, (byte)test4[j]);
                                dynaval++;
                            }
                            DebugData.Write(dynaval, (byte)0);
                            dynaval++;
                            break;
                        case "WString":
                            itemType = 4;
                            DebugData.Write(off + 0x4, dynaval);
                            string test5 = test.paramVals[i];
                            for (int j = 0; j < test5.Length; j++)
                            {
                                DebugData.Write(dynaval, test5[j]);
                                dynaval += 2;
                            }
                            DebugData.Write(dynaval, (char)0);
                            dynaval += 2;
                            break;
                    }
                    DebugData.Write(off + 0x8, itemType);
                    off += 0x10;
                }
            }
        }

        private void SLWB_Loadscr(object sender, EventArgs e)
        {
            if (scriptsListWBrkpnts.SelectedIndices.Count > 0)
                loadScriptCode(scriptsListWBrkpnts.SelectedIndices[0]);
        }

        private void SLWB_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && scriptsListWBrkpnts.SelectedItems.Count > 0)
            {
                if (GH3L)
                {
                    // WHY
                    ListViewItem selected = scriptsListWBrkpnts.SelectedItems[0];
                    int index = scriptsListWBrkpnts.Items.IndexOf(selected);
                    brkpnts[index] = !brkpnts[index];
                    scriptsListWBrkpnts.Items[index].ImageIndex = brkpnts[index] ? 1 : 0;
                    int i;
                    int j = 0;
                    for (i = 0; i < brkpnts.Length; i++)
                    {
                        if (brkpnts[i])
                        {
                            DebugData.Write(0xC000 + (j << 2),
                                QbKey.Create(
                                    scriptsListWBrkpnts.Items[index].Text).Crc);
                            j++;
                        }
                    }
                    DebugData.Write(0xC000 - 4, j);
                }
            }
        }

        private void restartGameBtn_Click(object sender, EventArgs e)
        {
            ReadCSD();
            if (!GH3.HasExited)
                GH3.Kill();
            StartOrUnpauseGame();
        }

        private void clickCodeList(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    /*Scripts[currentLoadedScript].brkpnt[e.RowIndex] =
                        !Scripts[currentLoadedScript].brkpnt[e.RowIndex];
                    Bitmap test0 = Properties.Resources.blank;
                    if (Scripts[currentLoadedScript].brkpnt[e.RowIndex])
                        test0 = Properties.Resources.RecordHS;
                    testCodeList.Rows[e.RowIndex].Cells[0].Value = test0;*/
                    break;
            }
        }

        private void SelectGame(object sender, EventArgs e)
        {
            if (OFD_EXE.ShowDialog() == DialogResult.OK)
            {
                LoadData(OFD_EXE.FileName);
            }
        }
    }
}
