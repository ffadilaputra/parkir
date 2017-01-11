using BEL;
using MetroFramework;
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
    public partial class FormKategori : MetroForm
    {

        public Category cat = new Category();
        public OperationsCategory opCat = new OperationsCategory(); 

        public FormKategori()
        {
            InitializeComponent();
            loadKaegoi();
        }

        public void loadKaegoi()
        {
            DataTable dd = new DataTable();
            dd = opCat.viewCategory(cat);
            metroGrid1.DataSource = dd;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormKategori_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            cat.Jenis = txtBoxJenis.Text;
            cat.Keterangan = txtBoxKeterangan.Text;
            cat.Harga = Int32.Parse(txtBoxHarga.Text);
            int row = opCat.insertCategory(cat);
            if (row > 0)
            {
                MetroMessageBox.Show(this, "Alert", "Tambah Data Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadKaegoi();    
            }
            else
            {
                MetroMessageBox.Show(this, "Alert", "Data Gagal Disimpan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metroTextBox3.Text = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txtBoxKeterangan.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
            txtBoxJenis.Text = metroGrid1.SelectedRows[0].Cells[2].Value.ToString();
            txtBoxHarga.Text = metroGrid1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            cat.Id = Int32.Parse(metroTextBox3.Text);
            opCat.delCategory(cat);
            loadKaegoi();
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            cat.Id = Int32.Parse(metroTextBox3.Text);
            cat.Keterangan = txtBoxKeterangan.Text;
            cat.Jenis = txtBoxJenis.Text;
            cat.Harga = Int32.Parse(txtBoxHarga.Text);
            opCat.updateCategory(cat);
            loadKaegoi();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
