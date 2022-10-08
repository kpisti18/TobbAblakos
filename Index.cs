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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void pCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PC pc = new PC();
            this.Hide();
            pc.Show();
        }

        private void notebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notebook notebook = new Notebook();
            this.Hide();
            notebook.Show();
        }
    }
}
