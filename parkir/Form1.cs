using parkir.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parkir
{
    public partial class Form1 : Form
    {

        public List<Jukir> dafarJukir = new List<Jukir>();
        public List<Category> daftarCategory = new List<Category>();
        

        public Form1()
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
            FormKategori f = new FormKategori(daftarCategory);
            f.ShowDialog();
        }

        private void jukirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormJukir jk = new FormJukir(dafarJukir);
            jk.ShowDialog();
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
