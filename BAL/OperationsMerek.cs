using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class OperationsMerek
    {
        public Dbconnection db = new Dbconnection();
        public Merek mer = new Merek();
        
        public DataTable viewMerek(Merek m)
        {
            SqlCommand s = new SqlCommand();
            s.CommandType = CommandType.Text;
            s.CommandText = "SELECT * FROM merk";
            return db.ExeReader(s);
        }

        public int insertMerek(Merek m)
        {
            SqlCommand s = new SqlCommand();
            s.CommandType = CommandType.Text;
            s.CommandText = "INSERT INTO merk VALUES('"+m.namaMerek+"')";
            return db.ExeNonQuery(s);
        }

        public int delMerek(Merek m)
        {
            SqlCommand s = new SqlCommand();
            s.CommandType = CommandType.Text;
            s.CommandText = "DELETE from merk WHERE id = '" + m.Id + "' ";
            return db.ExeNonQuery(s);
        }

        public int updMerek(Merek m)
        {
            SqlCommand s = new SqlCommand();
            s.CommandType = CommandType.Text;
            s.CommandText = "UPDATE merk SET merk_kend = '"+m.namaMerek+"' where id = '"+m.Id+"' ";
            return db.ExeNonQuery(s);
        }

    }
}
