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

namespace parkiran
{
    public partial class FormKendaraan : MetroForm
    {
        public FormKendaraan()
        {
            InitializeComponent();
        }

        private void FormKendaraan_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox1.Text == string.Empty)
            {
                MessageBox.Show("Kolom Plat Nomor tidak boleh kosong");
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(maskedTextBox1.Text, @"^[a-zA-Z,0-9\s]+$"))
            {
                MessageBox.Show("Kolom ini hanya bisa diisi abjad dan angka!");
                if(maskedTextBox1.Text.Length >= 1)
                {
                    maskedTextBox1.Text = maskedTextBox1.Text.Remove(maskedTextBox1.Text.Length - 1);
                }
            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox2.Text == string.Empty)
            {
                MessageBox.Show("Kolom Jam Masuk Tidak Boleh Kosong");
            }
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox3.Text == string.Empty)
            {
                MessageBox.Show("Kolom Jam Keluar Tidak Boleh Kosong");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
