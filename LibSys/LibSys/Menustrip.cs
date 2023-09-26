using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibSys
{
    public partial class Menustrip : Form
    {
        public Menustrip()
        {
            InitializeComponent();
        }

   

        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 book = new Form1();
            book.ShowDialog();

        }
    }
}
