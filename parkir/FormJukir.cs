using BEL;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BAL
{
    public partial class FormJukir : MetroForm
    {
        Jukir jk = new Jukir();
        Agama gg = new Agama();
        OperationsJukir opJek = new OperationsJukir();
        OperationsAgama opAga = new OperationsAgama();

        public FormJukir()
        {
            InitializeComponent();
            loadAgama();
        }

        public void loadAgama()
        {

            DataTable st = new DataTable();
            st = opAga.viewAgama(gg);
            metroComboBox1.DataSource = st;
            metroComboBox1.ValueMember = "id";
            metroComboBox1.DisplayMember = "Keterangan";           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormJukir_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(op.FileName);
                pathImage.Text = op.FileName;
                metroLabel9.Text = op.FileName;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void FormJukir_Load_1(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            jk.Nama = txtFullName.Text;
            jk.Email = txtPassword.Text;
            jk.Alamat = txtAlamat.Text;

            int idAgama = (int)metroComboBox1.SelectedValue;
            String ketAgama = metroComboBox1.DisplayMember;
            Agama agamaSelected = new Agama(idAgama, ketAgama);
            jk.Agamas = agamaSelected;

            if(radLakik.Checked == true)
            {
                jk.JK = radLakik.Text;
            }
            else if(radPer.Checked == true)
            {
                jk.JK = radPer.Text;
            }
            else
            {

            }
            jk.Username = txtUsername.Text;
            jk.Password = txtPassword.Text;
            opJek.insert(jk);
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
