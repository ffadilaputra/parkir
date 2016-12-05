using System;
using System.Windows.Forms;
using BEL;
using System.Collections.Generic;
using System.Data;

namespace BAL
{
    public partial class FormAgama : Form
    {

        private int rowIndex = 0;

        public Agama agg = new Agama();
        public OperationsAgama op = new OperationsAgama();

        private List<Agama> _daftarAgama;

        public List<Agama> DaftarAgama
        {
            get { return _daftarAgama; }
            set { _daftarAgama = value; }
        }

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
            dataGridView1.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAgama_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agg.Keterangan = textBox1.Text;
            int row = op.inserAgama(agg);

            if(row > 0)
            {
                MessageBox.Show("Data Berhasil Disimpan");
               
            }
            else
            {
                MessageBox.Show("Data Gagal Disimpan");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
    }
}
