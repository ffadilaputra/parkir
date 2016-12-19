
using BEL;
using MetroFramework.Forms;
using parkir;
using parkiran;
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
            FormKategori km = new FormKategori();
            km.ShowDialog();
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

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataJukirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dataJukirToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tambahJukirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJukir fj = new FormJukir();
            fj.ShowDialog();
        }

        private void merekKendaraanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMerek fk = new FormMerek();
            fk.ShowDialog();
        }

        private void parkirMasukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKendaraan ken = new FormKendaraan();
            ken.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
