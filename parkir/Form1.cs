
using BEL;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAL
{
    public partial class Parkiran : MetroForm
    {


        public Parkiran()
        {
            InitializeComponent();
        }

        private void jukirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kategoriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void jukirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void kustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKustomer fk = new FormKustomer();
            fk.ShowDialog();
        }

        private void agamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgama fa = new FormAgama();
            fa.ShowDialog();
        }
    }
}
