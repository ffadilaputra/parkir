using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            randomVal();
            getTime();
            getDate();
        }

        public void randomVal()
        {
            Random ran = new Random();
            int randomNum = ran.Next(0, 100);
            metroTextBox2.Text = Convert.ToString(randomNum);
        }

        public void getTime()
        {
            DateTime dt = DateTime.Now;
            metroLabel4.Text = dt.ToString("t", CultureInfo.CreateSpecificCulture("id-ID"));
        }

        public void getDate()
        {
            DateTime gg = DateTime.Now;
            metroLabel6.Text = gg.ToString("m", CultureInfo.CreateSpecificCulture("id-ID"));
        }

        private void FormKendaraan_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
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

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
