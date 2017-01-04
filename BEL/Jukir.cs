using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Jukir
    {
        private int _idJukir;

        public int IdJukir
        {   
            get { return _idJukir; }
            set { _idJukir = value; }
        }
        private string _nama;

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _alamat;

        public string Alamat
        {
            get { return _alamat; }
            set { _alamat = value; }
        }

        private Agama _agama;

        public Agama Agamas
        {
            get { return _agama; }
            set { _agama = value; }
        }

        private string _jk;

        public string JK
        {
            get { return _jk; }
            set { _jk = value; }
        }

        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
