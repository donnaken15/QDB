namespace QDB
{
    partial class dbUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Struct (0x14)", 6);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dbUI));
            this.mafiaToolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tipGen = new System.Windows.Forms.ToolTip(this.components);
            this.RTValuesTicker = new System.Windows.Forms.Timer(this.components);
            this.codeCont = new System.Windows.Forms.Panel();
            this.testCodeList = new System.Windows.Forms.DataGridView();
            this.brkpnt = new System.Windows.Forms.DataGridViewImageColumn();
            this.IPMatch = new System.Windows.Forms.DataGridViewImageColumn();
            this.addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disasmline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainSplitter1 = new System.Windows.Forms.SplitContainer();
            this.tabs = new System.Windows.Forms.TabControl();
            this.scriptCont = new System.Windows.Forms.TabPage();
            this.mainSplitter2 = new System.Windows.Forms.SplitContainer();
            this.curScrCont = new System.Windows.Forms.SplitContainer();
            this.currentScriptPanel = new System.Windows.Forms.Panel();
            this.ScrIPlbl = new System.Windows.Forms.Label();
            this.scriptNameAndGoto = new System.Windows.Forms.LinkLabel();
            this.CSDlabel = new System.Windows.Forms.Label();
            this.curScrStructPanel = new System.Windows.Forms.Panel();
            this.scriptDetailsSplit = new System.Windows.Forms.SplitContainer();
            this.curScrStructs = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QBItemsIcons = new System.Windows.Forms.ImageList(this.components);
            this.scriptStack = new System.Windows.Forms.ListView();
            this.scriptID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scriptIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scrStackLbl = new System.Windows.Forms.Label();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.OFD_EXE = new System.Windows.Forms.OpenFileDialog();
            this.CSDflags = new System.Windows.Forms.Label();
            this.openGameBtn = new System.Windows.Forms.ToolStripButton();
            this.existProcBtn = new System.Windows.Forms.ToolStripButton();
            this.runGameBtn = new System.Windows.Forms.ToolStripButton();
            this.pauseGameBtn = new System.Windows.Forms.ToolStripButton();
            this.stopGameBtn = new System.Windows.Forms.ToolStripButton();
            this.restartGameBtn = new System.Windows.Forms.ToolStripButton();
            this.stepCodeBtn = new System.Windows.Forms.ToolStripButton();
            this.stepOvBtn = new System.Windows.Forms.ToolStripButton();
            this.qbKeyEvalBtn = new System.Windows.Forms.ToolStripButton();
            this.ACEbtn = new System.Windows.Forms.ToolStripButton();
            this.scriptsListWBrkpnts = new System.Windows.Forms.ListView();
            this.scriptMain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scriptIcons = new System.Windows.Forms.ImageList(this.components);
            this.autostepBtn = new System.Windows.Forms.ToolStripButton();
            this.autoupdCSD = new System.Windows.Forms.ToolStripButton();
            this.mafiaToolBar.SuspendLayout();
            this.codeCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testCodeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitter1)).BeginInit();
            this.mainSplitter1.Panel1.SuspendLayout();
            this.mainSplitter1.Panel2.SuspendLayout();
            this.mainSplitter1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.scriptCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitter2)).BeginInit();
            this.mainSplitter2.Panel1.SuspendLayout();
            this.mainSplitter2.Panel2.SuspendLayout();
            this.mainSplitter2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curScrCont)).BeginInit();
            this.curScrCont.Panel1.SuspendLayout();
            this.curScrCont.Panel2.SuspendLayout();
            this.curScrCont.SuspendLayout();
            this.currentScriptPanel.SuspendLayout();
            this.curScrStructPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scriptDetailsSplit)).BeginInit();
            this.scriptDetailsSplit.Panel1.SuspendLayout();
            this.scriptDetailsSplit.Panel2.SuspendLayout();
            this.scriptDetailsSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // mafiaToolBar
            // 
            this.mafiaToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openGameBtn,
            this.existProcBtn,
            this.toolStripSeparator1,
            this.runGameBtn,
            this.pauseGameBtn,
            this.stopGameBtn,
            this.restartGameBtn,
            this.stepCodeBtn,
            this.autostepBtn,
            this.stepOvBtn,
            this.autoupdCSD,
            this.ACEbtn,
            this.toolStripSeparator2,
            this.qbKeyEvalBtn});
            this.mafiaToolBar.Location = new System.Drawing.Point(0, 0);
            this.mafiaToolBar.Name = "mafiaToolBar";
            this.mafiaToolBar.Size = new System.Drawing.Size(994, 25);
            this.mafiaToolBar.TabIndex = 0;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tipGen
            // 
            this.tipGen.AutoPopDelay = 5000;
            this.tipGen.InitialDelay = 100;
            this.tipGen.IsBalloon = true;
            this.tipGen.ReshowDelay = 100;
            this.tipGen.ToolTipTitle = "About this item";
            // 
            // RTValuesTicker
            // 
            this.RTValuesTicker.Interval = 40;
            this.RTValuesTicker.Tick += new System.EventHandler(this.RTValuesTicker_Tick);
            // 
            // codeCont
            // 
            this.codeCont.AutoScroll = true;
            this.codeCont.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.codeCont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.codeCont.Controls.Add(this.testCodeList);
            this.codeCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeCont.Location = new System.Drawing.Point(0, 0);
            this.codeCont.Name = "codeCont";
            this.codeCont.Size = new System.Drawing.Size(478, 674);
            this.codeCont.TabIndex = 7;
            // 
            // testCodeList
            // 
            this.testCodeList.AllowUserToAddRows = false;
            this.testCodeList.AllowUserToDeleteRows = false;
            this.testCodeList.AllowUserToResizeRows = false;
            this.testCodeList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.testCodeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.testCodeList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.testCodeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.testCodeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.testCodeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testCodeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brkpnt,
            this.IPMatch,
            this.addr,
            this.disasmline});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.testCodeList.DefaultCellStyle = dataGridViewCellStyle24;
            this.testCodeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testCodeList.Enabled = false;
            this.testCodeList.EnableHeadersVisualStyles = false;
            this.testCodeList.Location = new System.Drawing.Point(0, 0);
            this.testCodeList.Name = "testCodeList";
            this.testCodeList.ReadOnly = true;
            this.testCodeList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.testCodeList.RowHeadersVisible = false;
            this.testCodeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.testCodeList.RowTemplate.Height = 16;
            this.testCodeList.RowTemplate.ReadOnly = true;
            this.testCodeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.testCodeList.Size = new System.Drawing.Size(474, 670);
            this.testCodeList.TabIndex = 12;
            this.testCodeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickCodeList);
            // 
            // brkpnt
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.NullValue = "null";
            this.brkpnt.DefaultCellStyle = dataGridViewCellStyle20;
            this.brkpnt.HeaderText = "BP";
            this.brkpnt.MinimumWidth = 25;
            this.brkpnt.Name = "brkpnt";
            this.brkpnt.ReadOnly = true;
            this.brkpnt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.brkpnt.Visible = false;
            this.brkpnt.Width = 25;
            // 
            // IPMatch
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.NullValue = "null";
            this.IPMatch.DefaultCellStyle = dataGridViewCellStyle21;
            this.IPMatch.HeaderText = "";
            this.IPMatch.MinimumWidth = 25;
            this.IPMatch.Name = "IPMatch";
            this.IPMatch.ReadOnly = true;
            this.IPMatch.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IPMatch.Visible = false;
            this.IPMatch.Width = 25;
            // 
            // addr
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.addr.DefaultCellStyle = dataGridViewCellStyle22;
            this.addr.HeaderText = "Offset";
            this.addr.MinimumWidth = 40;
            this.addr.Name = "addr";
            this.addr.ReadOnly = true;
            this.addr.Width = 40;
            // 
            // disasmline
            // 
            this.disasmline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            this.disasmline.DefaultCellStyle = dataGridViewCellStyle23;
            this.disasmline.HeaderText = "Operation";
            this.disasmline.Name = "disasmline";
            this.disasmline.ReadOnly = true;
            // 
            // mainSplitter1
            // 
            this.mainSplitter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitter1.Location = new System.Drawing.Point(0, 25);
            this.mainSplitter1.Name = "mainSplitter1";
            // 
            // mainSplitter1.Panel1
            // 
            this.mainSplitter1.Panel1.Controls.Add(this.tabs);
            // 
            // mainSplitter1.Panel2
            // 
            this.mainSplitter1.Panel2.Controls.Add(this.mainSplitter2);
            this.mainSplitter1.Size = new System.Drawing.Size(994, 674);
            this.mainSplitter1.SplitterDistance = 234;
            this.mainSplitter1.SplitterWidth = 3;
            this.mainSplitter1.TabIndex = 9;
            // 
            // tabs
            // 
            this.tabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabs.Controls.Add(this.scriptCont);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(234, 674);
            this.tabs.TabIndex = 10;
            // 
            // scriptCont
            // 
            this.scriptCont.Controls.Add(this.scriptsListWBrkpnts);
            this.scriptCont.Location = new System.Drawing.Point(4, 25);
            this.scriptCont.Name = "scriptCont";
            this.scriptCont.Size = new System.Drawing.Size(226, 645);
            this.scriptCont.TabIndex = 2;
            this.scriptCont.Text = "Scripts";
            this.scriptCont.UseVisualStyleBackColor = true;
            // 
            // mainSplitter2
            // 
            this.mainSplitter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitter2.Location = new System.Drawing.Point(0, 0);
            this.mainSplitter2.Name = "mainSplitter2";
            // 
            // mainSplitter2.Panel1
            // 
            this.mainSplitter2.Panel1.Controls.Add(this.codeCont);
            // 
            // mainSplitter2.Panel2
            // 
            this.mainSplitter2.Panel2.Controls.Add(this.curScrCont);
            this.mainSplitter2.Size = new System.Drawing.Size(757, 674);
            this.mainSplitter2.SplitterDistance = 478;
            this.mainSplitter2.SplitterWidth = 3;
            this.mainSplitter2.TabIndex = 12;
            // 
            // curScrCont
            // 
            this.curScrCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.curScrCont.Location = new System.Drawing.Point(0, 0);
            this.curScrCont.Name = "curScrCont";
            this.curScrCont.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // curScrCont.Panel1
            // 
            this.curScrCont.Panel1.Controls.Add(this.currentScriptPanel);
            // 
            // curScrCont.Panel2
            // 
            this.curScrCont.Panel2.Controls.Add(this.curScrStructPanel);
            this.curScrCont.Size = new System.Drawing.Size(276, 674);
            this.curScrCont.SplitterDistance = 249;
            this.curScrCont.SplitterWidth = 3;
            this.curScrCont.TabIndex = 12;
            // 
            // currentScriptPanel
            // 
            this.currentScriptPanel.AutoScroll = true;
            this.currentScriptPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentScriptPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentScriptPanel.Controls.Add(this.CSDflags);
            this.currentScriptPanel.Controls.Add(this.ScrIPlbl);
            this.currentScriptPanel.Controls.Add(this.scriptNameAndGoto);
            this.currentScriptPanel.Controls.Add(this.CSDlabel);
            this.currentScriptPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentScriptPanel.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentScriptPanel.Location = new System.Drawing.Point(0, 0);
            this.currentScriptPanel.Name = "currentScriptPanel";
            this.currentScriptPanel.Size = new System.Drawing.Size(276, 249);
            this.currentScriptPanel.TabIndex = 11;
            // 
            // ScrIPlbl
            // 
            this.ScrIPlbl.AutoSize = true;
            this.ScrIPlbl.Enabled = false;
            this.ScrIPlbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ScrIPlbl.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScrIPlbl.Location = new System.Drawing.Point(59, 15);
            this.ScrIPlbl.Name = "ScrIPlbl";
            this.ScrIPlbl.Size = new System.Drawing.Size(29, 12);
            this.ScrIPlbl.TabIndex = 2;
            this.ScrIPlbl.Text = "0000";
            // 
            // scriptNameAndGoto
            // 
            this.scriptNameAndGoto.AutoSize = true;
            this.scriptNameAndGoto.Enabled = false;
            this.scriptNameAndGoto.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptNameAndGoto.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.scriptNameAndGoto.LinkColor = System.Drawing.Color.Blue;
            this.scriptNameAndGoto.Location = new System.Drawing.Point(56, 0);
            this.scriptNameAndGoto.Name = "scriptNameAndGoto";
            this.scriptNameAndGoto.Size = new System.Drawing.Size(29, 12);
            this.scriptNameAndGoto.TabIndex = 1;
            this.scriptNameAndGoto.Text = "null";
            this.scriptNameAndGoto.VisitedLinkColor = System.Drawing.Color.Blue;
            this.scriptNameAndGoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CSDgotoScript);
            // 
            // CSDlabel
            // 
            this.CSDlabel.AutoSize = true;
            this.CSDlabel.Enabled = false;
            this.CSDlabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CSDlabel.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSDlabel.Location = new System.Drawing.Point(3, 1);
            this.CSDlabel.Name = "CSDlabel";
            this.CSDlabel.Size = new System.Drawing.Size(59, 288);
            this.CSDlabel.TabIndex = 0;
            this.CSDlabel.Text = resources.GetString("CSDlabel.Text");
            // 
            // curScrStructPanel
            // 
            this.curScrStructPanel.Controls.Add(this.scriptDetailsSplit);
            this.curScrStructPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.curScrStructPanel.Enabled = false;
            this.curScrStructPanel.Location = new System.Drawing.Point(0, 0);
            this.curScrStructPanel.Name = "curScrStructPanel";
            this.curScrStructPanel.Size = new System.Drawing.Size(276, 422);
            this.curScrStructPanel.TabIndex = 1;
            // 
            // scriptDetailsSplit
            // 
            this.scriptDetailsSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptDetailsSplit.Location = new System.Drawing.Point(0, 0);
            this.scriptDetailsSplit.Name = "scriptDetailsSplit";
            this.scriptDetailsSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scriptDetailsSplit.Panel1
            // 
            this.scriptDetailsSplit.Panel1.Controls.Add(this.curScrStructs);
            // 
            // scriptDetailsSplit.Panel2
            // 
            this.scriptDetailsSplit.Panel2.Controls.Add(this.scriptStack);
            this.scriptDetailsSplit.Panel2.Controls.Add(this.scrStackLbl);
            this.scriptDetailsSplit.Panel2Collapsed = true;
            this.scriptDetailsSplit.Size = new System.Drawing.Size(276, 422);
            this.scriptDetailsSplit.SplitterDistance = 374;
            this.scriptDetailsSplit.TabIndex = 1;
            // 
            // curScrStructs
            // 
            this.curScrStructs.AutoArrange = false;
            this.curScrStructs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.value});
            this.curScrStructs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.curScrStructs.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curScrStructs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.curScrStructs.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.curScrStructs.Location = new System.Drawing.Point(0, 0);
            this.curScrStructs.Name = "curScrStructs";
            this.curScrStructs.Size = new System.Drawing.Size(276, 422);
            this.curScrStructs.SmallImageList = this.QBItemsIcons;
            this.curScrStructs.TabIndex = 1;
            this.curScrStructs.UseCompatibleStateImageBehavior = false;
            this.curScrStructs.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Item";
            this.name.Width = 150;
            // 
            // value
            // 
            this.value.Text = "Value";
            this.value.Width = 120;
            // 
            // QBItemsIcons
            // 
            this.QBItemsIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("QBItemsIcons.ImageStream")));
            this.QBItemsIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.QBItemsIcons.Images.SetKeyName(0, "array");
            this.QBItemsIcons.Images.SetKeyName(1, "single");
            this.QBItemsIcons.Images.SetKeyName(2, "num");
            this.QBItemsIcons.Images.SetKeyName(3, "key");
            this.QBItemsIcons.Images.SetKeyName(4, "script");
            this.QBItemsIcons.Images.SetKeyName(5, "text");
            this.QBItemsIcons.Images.SetKeyName(6, "struc");
            this.QBItemsIcons.Images.SetKeyName(7, "numalt");
            this.QBItemsIcons.Images.SetKeyName(8, "unknown");
            this.QBItemsIcons.Images.SetKeyName(9, "qb");
            this.QBItemsIcons.Images.SetKeyName(10, "unkfile");
            this.QBItemsIcons.Images.SetKeyName(11, "image");
            this.QBItemsIcons.Images.SetKeyName(12, "qs");
            this.QBItemsIcons.Images.SetKeyName(13, "musf");
            this.QBItemsIcons.Images.SetKeyName(14, "ptr");
            // 
            // scriptStack
            // 
            this.scriptStack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptStack.AutoArrange = false;
            this.scriptStack.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.scriptID,
            this.scriptIP});
            this.scriptStack.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptStack.FullRowSelect = true;
            this.scriptStack.GridLines = true;
            this.scriptStack.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem4.StateImageIndex = 0;
            this.scriptStack.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.scriptStack.Location = new System.Drawing.Point(3, 27);
            this.scriptStack.MultiSelect = false;
            this.scriptStack.Name = "scriptStack";
            this.scriptStack.Size = new System.Drawing.Size(291, 56);
            this.scriptStack.TabIndex = 2;
            this.scriptStack.UseCompatibleStateImageBehavior = false;
            this.scriptStack.View = System.Windows.Forms.View.Details;
            // 
            // scriptID
            // 
            this.scriptID.Text = "Script";
            this.scriptID.Width = 164;
            // 
            // scriptIP
            // 
            this.scriptIP.Text = "IP";
            this.scriptIP.Width = 80;
            // 
            // scrStackLbl
            // 
            this.scrStackLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.scrStackLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrStackLbl.Location = new System.Drawing.Point(0, 0);
            this.scrStackLbl.Name = "scrStackLbl";
            this.scrStackLbl.Size = new System.Drawing.Size(297, 24);
            this.scrStackLbl.TabIndex = 1;
            this.scrStackLbl.Text = "Script Stack (DOES THIS WORK?!?!)";
            this.scrStackLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusbar
            // 
            this.statusbar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusbar.Location = new System.Drawing.Point(0, 677);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(923, 22);
            this.statusbar.TabIndex = 10;
            this.statusbar.Text = "WHY CANT MAIN PANEL HEIGHT CUT BEFORE THIS";
            this.statusbar.Visible = false;
            // 
            // OFD_EXE
            // 
            this.OFD_EXE.DefaultExt = "exe";
            this.OFD_EXE.Filter = "Guitar Hero III Executable|*.exe";
            this.OFD_EXE.RestoreDirectory = true;
            this.OFD_EXE.SupportMultiDottedExtensions = true;
            // 
            // CSDflags
            // 
            this.CSDflags.AutoSize = true;
            this.CSDflags.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CSDflags.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSDflags.Location = new System.Drawing.Point(71, 49);
            this.CSDflags.Name = "CSDflags";
            this.CSDflags.Size = new System.Drawing.Size(11, 12);
            this.CSDflags.TabIndex = 3;
            this.CSDflags.Text = "0";
            // 
            // openGameBtn
            // 
            this.openGameBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openGameBtn.Image = global::QDB.Properties.Resources.openHS;
            this.openGameBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openGameBtn.Name = "openGameBtn";
            this.openGameBtn.Size = new System.Drawing.Size(23, 22);
            this.openGameBtn.ToolTipText = "Open Game Executable";
            this.openGameBtn.Click += new System.EventHandler(this.SelectGame);
            // 
            // existProcBtn
            // 
            this.existProcBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.existProcBtn.Image = global::QDB.Properties.Resources.WindowsHS;
            this.existProcBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.existProcBtn.Name = "existProcBtn";
            this.existProcBtn.Size = new System.Drawing.Size(23, 22);
            this.existProcBtn.Text = "toolStripButton1";
            this.existProcBtn.ToolTipText = "Attach to Process (DEFINITELY WILL NOT WORK OUT)";
            this.existProcBtn.Visible = false;
            // 
            // runGameBtn
            // 
            this.runGameBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runGameBtn.Enabled = false;
            this.runGameBtn.Image = global::QDB.Properties.Resources.PlayHS;
            this.runGameBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runGameBtn.Name = "runGameBtn";
            this.runGameBtn.Size = new System.Drawing.Size(23, 22);
            this.runGameBtn.ToolTipText = "Run / Continue";
            this.runGameBtn.Click += new System.EventHandler(this.RunClick);
            // 
            // pauseGameBtn
            // 
            this.pauseGameBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseGameBtn.Enabled = false;
            this.pauseGameBtn.Image = global::QDB.Properties.Resources.PauseHS;
            this.pauseGameBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseGameBtn.Name = "pauseGameBtn";
            this.pauseGameBtn.Size = new System.Drawing.Size(23, 22);
            this.pauseGameBtn.ToolTipText = "Pause";
            this.pauseGameBtn.Click += new System.EventHandler(this.pauseGameBtn_Click);
            // 
            // stopGameBtn
            // 
            this.stopGameBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopGameBtn.Enabled = false;
            this.stopGameBtn.Image = global::QDB.Properties.Resources.StopHS;
            this.stopGameBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopGameBtn.Name = "stopGameBtn";
            this.stopGameBtn.Size = new System.Drawing.Size(23, 22);
            this.stopGameBtn.ToolTipText = "Stop";
            this.stopGameBtn.Click += new System.EventHandler(this.stopGameBtn_Click);
            // 
            // restartGameBtn
            // 
            this.restartGameBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.restartGameBtn.Enabled = false;
            this.restartGameBtn.Image = global::QDB.Properties.Resources.RepeatHS;
            this.restartGameBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.restartGameBtn.Name = "restartGameBtn";
            this.restartGameBtn.Size = new System.Drawing.Size(23, 22);
            this.restartGameBtn.ToolTipText = "Restart";
            this.restartGameBtn.Visible = false;
            this.restartGameBtn.Click += new System.EventHandler(this.restartGameBtn_Click);
            // 
            // stepCodeBtn
            // 
            this.stepCodeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stepCodeBtn.Enabled = false;
            this.stepCodeBtn.Image = global::QDB.Properties.Resources.RightArrowHS;
            this.stepCodeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stepCodeBtn.Name = "stepCodeBtn";
            this.stepCodeBtn.Size = new System.Drawing.Size(23, 22);
            this.stepCodeBtn.ToolTipText = "Step Into";
            this.stepCodeBtn.Click += new System.EventHandler(this.stepCodeBtn_Click);
            // 
            // stepOvBtn
            // 
            this.stepOvBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stepOvBtn.Enabled = false;
            this.stepOvBtn.Image = global::QDB.Properties.Resources.DoubleRightArrowHS;
            this.stepOvBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stepOvBtn.Name = "stepOvBtn";
            this.stepOvBtn.Size = new System.Drawing.Size(23, 22);
            this.stepOvBtn.ToolTipText = "Step Over";
            this.stepOvBtn.Visible = false;
            this.stepOvBtn.Click += new System.EventHandler(this.stepOvBtn_Click);
            // 
            // qbKeyEvalBtn
            // 
            this.qbKeyEvalBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.qbKeyEvalBtn.Image = global::QDB.Properties.Resources.EntityDataModel_property_with_key_16x16;
            this.qbKeyEvalBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.qbKeyEvalBtn.Name = "qbKeyEvalBtn";
            this.qbKeyEvalBtn.Size = new System.Drawing.Size(23, 22);
            this.qbKeyEvalBtn.ToolTipText = "QbKey Calculator";
            this.qbKeyEvalBtn.Click += new System.EventHandler(this.qbKeyEvalBtn_Click);
            // 
            // ACEbtn
            // 
            this.ACEbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ACEbtn.Enabled = false;
            this.ACEbtn.Image = global::QDB.Properties.Resources.FunctionHS;
            this.ACEbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ACEbtn.Name = "ACEbtn";
            this.ACEbtn.Size = new System.Drawing.Size(23, 22);
            this.ACEbtn.ToolTipText = "Execute function";
            this.ACEbtn.Click += new System.EventHandler(this.runScriptDiag);
            // 
            // scriptsListWBrkpnts
            // 
            this.scriptsListWBrkpnts.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.scriptsListWBrkpnts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.scriptMain});
            this.scriptsListWBrkpnts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptsListWBrkpnts.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptsListWBrkpnts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.scriptsListWBrkpnts.Location = new System.Drawing.Point(0, 0);
            this.scriptsListWBrkpnts.MultiSelect = false;
            this.scriptsListWBrkpnts.Name = "scriptsListWBrkpnts";
            this.scriptsListWBrkpnts.ShowGroups = false;
            this.scriptsListWBrkpnts.Size = new System.Drawing.Size(226, 645);
            this.scriptsListWBrkpnts.SmallImageList = this.scriptIcons;
            this.scriptsListWBrkpnts.TabIndex = 3;
            this.scriptsListWBrkpnts.UseCompatibleStateImageBehavior = false;
            this.scriptsListWBrkpnts.View = System.Windows.Forms.View.SmallIcon;
            this.scriptsListWBrkpnts.ItemActivate += new System.EventHandler(this.SLWB_Loadscr);
            this.scriptsListWBrkpnts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SLWB_click);
            // 
            // scriptMain
            // 
            this.scriptMain.Text = "";
            this.scriptMain.Width = 200;
            // 
            // scriptIcons
            // 
            this.scriptIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("scriptIcons.ImageStream")));
            this.scriptIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.scriptIcons.Images.SetKeyName(0, "none");
            this.scriptIcons.Images.SetKeyName(1, "brkpnt");
            this.scriptIcons.Images.SetKeyName(2, "running");
            // 
            // autostepBtn
            // 
            this.autostepBtn.CheckOnClick = true;
            this.autostepBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.autostepBtn.Enabled = false;
            this.autostepBtn.Image = global::QDB.Properties.Resources.Animate;
            this.autostepBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.autostepBtn.Name = "autostepBtn";
            this.autostepBtn.Size = new System.Drawing.Size(23, 22);
            this.autostepBtn.Text = "toolStripButton1";
            this.autostepBtn.ToolTipText = "Animate Step";
            // 
            // autoupdCSD
            // 
            this.autoupdCSD.CheckOnClick = true;
            this.autoupdCSD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.autoupdCSD.Image = global::QDB.Properties.Resources.Control_Timer;
            this.autoupdCSD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.autoupdCSD.Name = "autoupdCSD";
            this.autoupdCSD.Size = new System.Drawing.Size(23, 22);
            this.autoupdCSD.ToolTipText = "Auto-update CSD (Note: may only display useful values)";
            this.autoupdCSD.Visible = false;
            // 
            // dbUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 699);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.mainSplitter1);
            this.Controls.Add(this.mafiaToolBar);
            this.Name = "dbUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QDB -- QbScript Debugger (GH3)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exiting);
            this.mafiaToolBar.ResumeLayout(false);
            this.mafiaToolBar.PerformLayout();
            this.codeCont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testCodeList)).EndInit();
            this.mainSplitter1.Panel1.ResumeLayout(false);
            this.mainSplitter1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitter1)).EndInit();
            this.mainSplitter1.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.scriptCont.ResumeLayout(false);
            this.mainSplitter2.Panel1.ResumeLayout(false);
            this.mainSplitter2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitter2)).EndInit();
            this.mainSplitter2.ResumeLayout(false);
            this.curScrCont.Panel1.ResumeLayout(false);
            this.curScrCont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.curScrCont)).EndInit();
            this.curScrCont.ResumeLayout(false);
            this.currentScriptPanel.ResumeLayout(false);
            this.currentScriptPanel.PerformLayout();
            this.curScrStructPanel.ResumeLayout(false);
            this.scriptDetailsSplit.Panel1.ResumeLayout(false);
            this.scriptDetailsSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scriptDetailsSplit)).EndInit();
            this.scriptDetailsSplit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mafiaToolBar;
        private System.Windows.Forms.ToolStripButton openGameBtn;
        private System.Windows.Forms.ToolStripButton existProcBtn;
        private System.Windows.Forms.ToolTip tipGen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton runGameBtn;
        private System.Windows.Forms.ToolStripButton pauseGameBtn;
        private System.Windows.Forms.ToolStripButton stopGameBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton restartGameBtn;
        private System.Windows.Forms.ToolStripButton stepCodeBtn;
        private System.Windows.Forms.ToolStripButton stepOvBtn;
        private System.Windows.Forms.Timer RTValuesTicker;
        private System.Windows.Forms.Panel codeCont;
        private System.Windows.Forms.SplitContainer mainSplitter1;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.Panel currentScriptPanel;
        private System.Windows.Forms.Label CSDlabel;
        private System.Windows.Forms.DataGridView testCodeList;
        private System.Windows.Forms.SplitContainer mainSplitter2;
        private System.Windows.Forms.TabPage scriptCont;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.SplitContainer curScrCont;
        private System.Windows.Forms.ToolStripButton qbKeyEvalBtn;
        private System.Windows.Forms.OpenFileDialog OFD_EXE;
        private System.Windows.Forms.LinkLabel scriptNameAndGoto;
        private System.Windows.Forms.Label ScrIPlbl;
        private System.Windows.Forms.ImageList QBItemsIcons;
        private System.Windows.Forms.DataGridViewImageColumn brkpnt;
        private System.Windows.Forms.DataGridViewImageColumn IPMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn disasmline;
        private System.Windows.Forms.Panel curScrStructPanel;
        private System.Windows.Forms.SplitContainer scriptDetailsSplit;
        private System.Windows.Forms.Label scrStackLbl;
        private System.Windows.Forms.ListView scriptStack;
        private System.Windows.Forms.ColumnHeader scriptID;
        private System.Windows.Forms.ColumnHeader scriptIP;
        private System.Windows.Forms.ListView curScrStructs;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader value;
        private System.Windows.Forms.Label CSDflags;
        private System.Windows.Forms.ToolStripButton ACEbtn;
        private System.Windows.Forms.ListView scriptsListWBrkpnts;
        private System.Windows.Forms.ColumnHeader scriptMain;
        private System.Windows.Forms.ImageList scriptIcons;
        private System.Windows.Forms.ToolStripButton autostepBtn;
        private System.Windows.Forms.ToolStripButton autoupdCSD;
    }
}

