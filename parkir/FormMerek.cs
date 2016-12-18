using BAL;
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

namespace parkir
{
    public partial class FormMerek : MetroForm
    {

        public Merek mer = new Merek();
        public OperationsMerek op = new OperationsMerek();

        public FormMerek()
        {
            InitializeComponent();
            loadMerek();
        }

        public void loadMerek()
        {
            DataTable al = new DataTable();
            al = op.viewMerek(mer);
            metroGrid1.DataSource = al;
        }

        private void FormMerek_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            metroTextBox1.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
            metroTextBox3.Text = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            metroButton1.Enabled = false;
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            loadMerek();
            metroButton1.Enabled = true;
            metroTextBox3.Text = "";
            metroTextBox1.Text = "";
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            mer.Id = Int32.Parse(metroTextBox3.Text);
            mer.namaMerek = metroTextBox1.Text;
            op.updMerek(mer);
            loadMerek();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            mer.Id = Int32.Parse(metroTextBox3.Text);
            mer.namaMerek = metroTextBox1.Text;
            op.delMerek(mer);
            loadMerek();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            mer.namaMerek= metroTextBox1.Text;
            int row = op.insertMerek(mer);

            if (row > 0)
            {
                MetroMessageBox.Show(this, "Alert", "Tambah Data Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadMerek();
            }
            else
            {
                MetroMessageBox.Show(this, "Alert", "Data Gagal Disimpan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
