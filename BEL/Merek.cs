using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Merek
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string  _namaMerk;

        public string  namaMerek
        {
            get { return _namaMerk; }
            set { _namaMerk = value; }
        }


    }
}
