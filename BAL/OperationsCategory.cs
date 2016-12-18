using BEL;
using DAL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BAL
{
    public class OperationsCategory
    {
        public Dbconnection db = new Dbconnection();
        public Category cat = new Category();

        public DataTable viewCategory(Category cat)
        {
            SqlCommand v = new SqlCommand();
            v.CommandType = CommandType.Text;
            v.CommandText = "SELECT * FROM kategori";
            return db.ExeReader(v);
        }

        public int insertCategory(Category cat)
        {
            SqlCommand inset = new SqlCommand();
            inset.CommandType = CommandType.Text;
            inset.CommandText = "INSERT INTO kategori VALUES('" + cat.Jenis + "','" + cat.Keterangan + "','"+cat.Harga+"')";
            return db.ExeNonQuery(inset);
        }

        public int delCategory(Category cat)
        {
            SqlCommand del = new SqlCommand();
            del.CommandType = CommandType.Text;
            del.CommandText = "DELETE FROM kategori where id = '" + cat.Id + "'";
            return db.ExeNonQuery(del);
        }

        public int updateCategory(Category c)
        {
            SqlCommand upd = new SqlCommand();
            upd.CommandType = CommandType.Text;
            upd.CommandText = "UPDATE kategori SET keterangan = '" + c.Keterangan + "', jenis = '" + c.Jenis + "',harga = '" + c.Harga + "' where id = '" + c.Id + "'";
            return db.ExeNonQuery(upd);
        }

    }
}
