using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace parkir
{
    public partial class FormLogin : MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            if (metroTextBox2.Text == String.Empty)
            {
                MessageBox.Show("Masukkan Password");
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == String.Empty)
            {
                MessageBox.Show("Masukkan Username!");
            }
        }
    }
}
