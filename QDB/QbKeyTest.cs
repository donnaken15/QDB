using Nanook.QueenBee.Parser;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QDB
{
    public partial class QbKeyTest : Form
    {
        bool editMode = false;
        Dictionary<uint, string> names;

        public QbKeyTest(Dictionary<uint, string> ASCIIkeys)
        {
            InitializeComponent();
            names = ASCIIkeys;
        }

        private void changeBasedOnText(object sender, EventArgs e)
        {
            if (!editMode)
            {
                inputHex.Text = QbKey.Create(inputString.Text).Crc.ToString("X8");
            }
        }

        private void changeBasedOnCRC(object sender, EventArgs e)
        {
            if (editMode)
            {
                try
                {
                    inputString.Text = names[uint.Parse(inputHex.Text, System.Globalization.NumberStyles.HexNumber)];
                }
                catch
                {
                    inputString.Text = "unknown";
                }
            }
        }

        private void editMode2Str(object sender, EventArgs e)
        {
            editMode = false;
        }

        private void editMode2CRC(object sender, EventArgs e)
        {
            editMode = true;
        }
    }
}
