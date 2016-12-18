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

namespace BAL
{
    public partial class FormJukir : MetroForm
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
    }
}
