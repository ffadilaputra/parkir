using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Dbconnection
    {
        public SqlConnection koneksi = new SqlConnection("Data Source=DOUBLE-PC;Initial Catalog=parkiran;Integrated Security=True");
       
        public SqlConnection getCon()
        {
            if(koneksi.State == ConnectionState.Closed)
            {
                koneksi.Open();
            }
            return koneksi;
        }

        public int ExeNonQuery(SqlCommand cmd)
        {
            cmd.Connection = getCon();
            int rowsaffected = -1;
            rowsaffected = cmd.ExecuteNonQuery();
            koneksi.Close();
            return rowsaffected;
        }

        public object ExeScalar(SqlCommand cm)
        {
            cm.Connection = getCon();
            object obj = -1;
            obj = cm.ExecuteScalar();
            koneksi.Close();
            return obj;
        }

        public DataTable ExeReader(SqlCommand cm)
        {
            cm.Connection = getCon();
            SqlDataReader ldr;
            DataTable dat = new DataTable();

            ldr = cm.ExecuteReader();
            dat.Load(ldr);
            koneksi.Close();
            return dat;

        }

    }
}
