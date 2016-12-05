using BEL;
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
    public partial class FormJukir : Form
    {
        private List<Jukir> _datarJukir;

        public List<Jukir> DaftarJukir
        {
            get { return _datarJukir; }
            set { _datarJukir = value; }
        }

        private List<Jukir> daftarJukir;

        public FormJukir()
        {
            InitializeComponent();
        }

        public FormJukir(List<Jukir> dafarJukir)
        {
            InitializeComponent();
            DaftarJukir = dafarJukir;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "ID Jukir";
            dataGridView1.Columns[1].Name = "Nama Jukir";
            

            loadJukir();
        }

        public void loadJukir()
        {
            foreach(var jukir in DaftarJukir)
            {
                dataGridView1.Rows.Add(jukir.IdJukir,jukir.Nama);            
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormJukir_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || textBox1.Text == "0" || textBox2.Text == String.Empty || textBox2.Text == "0")
            {
                MessageBox.Show("Maaf Tidak Boleh Kosong ");
            }
            else
            {
                Jukir itemJukir = new Jukir();
                itemJukir.IdJukir = textBox1.Text;
                itemJukir.Nama = textBox2.Text;

                DaftarJukir.Add(itemJukir);

                dataGridView1.Rows.Add(itemJukir.IdJukir, itemJukir.Nama);

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
