using Nanook.QueenBee.Parser;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QDB
{
    public partial class ACEDiag : Form
    {
        public QbKey scrKey;

        public string[] paramTypes;
        public QbKey [] paramKeys;
        public string[] paramVals;

        public ACEDiag()
        {
            InitializeComponent();
        }

        private void Go(object sender, EventArgs e)
        {
            scrKey = QbKey.Create(scrName.Text);
            paramTypes = new string[nodes.Rows.Count - 1];
            paramKeys = new QbKey [paramTypes.Length];
            paramVals = new string[paramTypes.Length];
            for (int i = 0; i < paramTypes.Length; i++)
            {
                paramTypes[i] = nodes.Rows[i].Cells[0].Value.ToString();
                paramKeys [i] = QbKey.Create(nodes.Rows[i].Cells[1].Value.ToString());
                paramVals [i] = nodes.Rows[i].Cells[2].Value.ToString();
            }
            if (nodes.Rows.Count > 16)
            {
                MessageBox.Show("Too many params inputted. Only the first 16 will be passed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
