using DAL;
using BEL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
    public class OperationsAgama
    {
        public Dbconnection db = new Dbconnection();
        public Agama ag = new Agama();

        public int inserAgama(Agama agg)
        {
            SqlCommand query = new SqlCommand();
            query.CommandType = CommandType.Text;
            query.CommandText = "INSERT INTO agama VALUES('"+agg.Keterangan+"')";
            return db.ExeNonQuery(query);
        }

        public int updateAgama(Agama agg) {

            SqlCommand query = new SqlCommand();
            query.CommandType = CommandType.Text;
            query.CommandText = "UPDATE agama SET keterangan='"+agg.Keterangan+"' where id='"+agg.Id+"'";
            return db.ExeNonQuery(query);
        }

        public int delAgama(Agama agg)
        {
            SqlCommand del = new SqlCommand();
            del.CommandType = CommandType.Text;
            del.CommandText = "DELETE FROM agama WHERE id =  '"+agg.Id+"'";
            return db.ExeNonQuery(del);
        }

        public DataTable viewAgama(Agama agg)
        {
            SqlCommand view = new SqlCommand();
            view.CommandType = CommandType.Text;
            view.CommandText = "SELECT * FROM agama";
            return db.ExeReader(view);
        }
    }
}  