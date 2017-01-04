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

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
