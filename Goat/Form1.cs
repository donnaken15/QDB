
using System;
using System.IO.MemoryMappedFiles;
using System.Threading;
using System.Windows.Forms;

namespace Goat
{
    public partial class Form1 : Form
    {
        Mutex MTX;
        bool MTXsuccess;
        MemoryMappedFile MMF;
        const uint MMFsz = 16384;

        public Form1()
        {
            InitializeComponent();
            try
            {
                MMF = MemoryMappedFile.OpenExisting("GH3_QDebug_DTA");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(),"ERROR");
                Environment.Exit(1);
            }

            notgood.Start();
        }

        char test;
        private void update(object sender, System.EventArgs e)
        {
            textBox1.Text = "";
            using (var accessor = MMF.CreateViewAccessor(0, 20))
            {
                textBox1.Text += accessor.ReadChar(8).ToString();
                textBox1.Text += accessor.ReadChar(9).ToString();
                textBox1.Text += accessor.ReadChar(10).ToString();
                textBox1.Text += accessor.ReadChar(11).ToString();
                textBox1.Text += accessor.ReadChar(12).ToString();
                test = accessor.ReadChar(1);
                textBox1.Text += test;
                while (test == 'A')
                {
                    /*MTX = new Mutex(false, "Global\\GH3_QDebug_IPC", out MTXsuccess);
                    if (!MTXsuccess)
                    {
                        MTX.WaitOne(4000);
                        //MessageBox.Show("Mutex failed to be created.", "ERROR",
                            //MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    }
                    MTX.ReleaseMutex();*/
                    // CHEAPPP
                    Thread.Sleep(5);
                    test = accessor.ReadChar(1);
                }
            }
            textBox2.Text += "A";
        }

        private void Exiting(object sender, FormClosedEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            using (var accessor = MMF.CreateViewAccessor(0, 100))
            {
                accessor.Write(20, numericUpDown1.Value);
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            using (var accessor = MMF.CreateViewAccessor(0, 100))
            {
                accessor.Write(40, numericUpDown2.Value);
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            using (var accessor = MMF.CreateViewAccessor(0, 100))
            {
                accessor.Write(60, numericUpDown3.Value);
            }
        }
    }
}
