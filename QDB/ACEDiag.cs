using Nanook.QueenBee.Parser;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QDB
{
    public partial class ACEDiag : Form
    {
        public QbKey scrKey;

        public ACEDiag()
        {
            InitializeComponent();
        }

        private void Go(object sender, EventArgs e)
        {
            scrKey = QbKey.Create(scrName.Text);
        }
    }
}
