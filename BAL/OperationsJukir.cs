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
    public class OperationsJukir
    {

        public Dbconnection db = new Dbconnection();
        public Jukir jk = new Jukir();

        public DataTable view(Jukir j)
        {
            SqlCommand v = new SqlCommand();
            v.CommandType = CommandType.Text;
            v.CommandText = "select a.id,a.nama,a.username,a.email,a.alamat,b.keterangan,a.jenkel from jukir a join agama b on a.fk_agm=b.id";
            return db.ExeReader(v);
        }

        public int insert(Jukir j)
        {
            SqlCommand query = new SqlCommand();
            query.CommandType = CommandType.Text;
            query.CommandText = "INSERT INTO jukir VALUES('" + j.Nama + "','"+j.Email+"','"+j.Alamat+"','"+j.Agamas.Id+"','"+j.JK+"','"+j.Username+"','"+j.Password+"')";
            return db.ExeNonQuery(query);
        }

        public int update(Jukir j)
        {
            SqlCommand update = new SqlCommand();
            update.CommandType = CommandType.Text;
            update.CommandText = "UPDATE jukir SET nama='"+j.Nama+"',email='"+j.Email+"',alamat='"+j.Alamat+"',fk_agama='"+j.Agamas.Id+"',jenkel='"+j.JK+ "',username='" + j.Username+"',passwd='"+j.Password+"'";
            return db.ExeNonQuery(update);
        }

        public int delete(Jukir j)
        {
            SqlCommand del = new SqlCommand();
            del.CommandType = CommandType.Text;
            del.CommandText = "DELETE FROM jukir where id = '" + j.IdJukir + "'";
            return db.ExeNonQuery(del);
        }
    }
}
