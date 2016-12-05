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
    public partial class FormKategori : Form
    {

        private List<Category> _daftarCategory;

        public List<Category> DaftarCategory
        {
            get { return _daftarCategory; }
            set { _daftarCategory = value; }
        }

        private List<Category> daftarCateory;


        public FormKategori()
        {
            InitializeComponent();
        }

        public void loadKaegoi()
        {
            foreach(var kat in DaftarCategory)
            {
                dataGridView1.Rows.Add(kat.Keterangan, kat.Jenis);
            }
        }

        public FormKategori(List<Category> daftarCategory)
        {
            InitializeComponent();
            DaftarCategory = daftarCategory;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Keteranan";
            dataGridView1.Columns[1].Name = "Jenis";
            loadKaegoi();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormKategori_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == String.Empty || textBox1.Text == "0" || textBox2.Text == String.Empty || textBox2.Text == "0")
            {
                MessageBox.Show(" Maaf Tidak Boleh Kosong ");
            }
            else
            {
                Category cc = new Category();
                cc.Jenis = textBox1.Text;
                cc.Keterangan = textBox2.Text;

                DaftarCategory.Add(cc);
                dataGridView1.Rows.Add(cc.Jenis, cc.Keterangan);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
