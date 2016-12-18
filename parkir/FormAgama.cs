using System;
using System.Windows.Forms;
using BEL;
using System.Collections.Generic;
using System.Data;
using MetroFramework.Forms;

namespace BAL
{
    public partial class FormAgama : MetroForm
    {

        private int rowIndex = 0;

        public Agama agg = new Agama();
        public OperationsAgama op = new OperationsAgama();

        public FormAgama()
        {
            InitializeComponent();
            loadAgama();

        }

        public FormAgama(List<Agama> daftarAgama)
        {
            InitializeComponent();
            
        }


        public void loadAgama()
        {
            DataTable dt = new DataTable();
            dt = op.viewAgama(agg);
            metroGrid1.DataSource = dt;           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
          
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            agg.Keterangan = metroTextBox1.Text;
            int row = op.inserAgama(agg);

            if (row > 0)
            {
                MessageBox.Show("Data Berhasil Disimpan");
                loadAgama();
            }
            else
            {
                MessageBox.Show("Data Gagal Disimpan");
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void metroGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void metroGrid1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            agg.Id = Int32.Parse(metroTextBox2.Text);
            op.delAgama(agg);
            loadAgama();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metroTextBox2.Text = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            metroTextBox1.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            agg.Id = Int32.Parse(metroTextBox2.Text);
            agg.Keterangan = metroTextBox1.Text;
            op.updateAgama(agg);
            loadAgama();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
