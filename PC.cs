using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobbAblakos
{
    public partial class PC : Form
    {
        public PC()
        {
            InitializeComponent();
        }

        private void PC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Valóban be szeretné zárni?", "Bezárás", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.index.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
