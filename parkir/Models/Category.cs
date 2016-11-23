using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkir.Models
{
    public class Category
    {

        private string _keterangan;

        public string Keterangan
        {
            get { return _keterangan; }
            set { _keterangan = value; }
        }

        private string _jenis;

        public string Jenis 
        {
            get { return _jenis; }
            set { _jenis = value; }
        }



    }
}
