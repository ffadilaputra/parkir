using BAL;
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

namespace parkir
{
    public partial class DataJukir : MetroForm
    {
        Jukir okKir = new Jukir();
        OperationsJukir opKir = new OperationsJukir(); 

        public DataJukir()
        {
            InitializeComponent();
            loadJukir();
        }

        public void loadJukir()
        {
            DataTable dt = new DataTable();
            dt = opKir.view(okKir);
            metroGrid1.DataSource = dt;
        }

        private void DataJukir_Load(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metroLabel1.Text = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txtNama.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
            txtEmail.Text = metroGrid1.SelectedRows[0].Cells[2].Value.ToString();
            txtAlamat.Text = metroGrid1.SelectedRows[0].Cells[3].Value.ToString();
            //
            //
            txtUsername.Text = metroGrid1.SelectedRows[0].Cells[5].Value.ToString();
            txtPassword.Text = metroGrid1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FormJukir jj = new FormJukir();
            jj.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            okKir.IdJukir = Int32.Parse(metroLabel1.Text);
            opKir.delete(okKir);
            loadJukir();
        }
    }
}
