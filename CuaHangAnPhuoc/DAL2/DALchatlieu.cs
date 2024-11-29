using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALchatlieu
    {
        DatabaseAccessLayer db;

        public DALchatlieu(string connectionString)
        {
            db = new DatabaseAccessLayer(connectionString);
        }
        public DataTable load()
        {
            string query = "SELECT * FROM chatchieu";
            DataTable dt = new DataTable();
            dt = db.ExecuteQuery(query);
            return dt;
        }
        public bool insert(chatlieu _chatlieu)
        {
            string query = "INSERT INTO chatlieu (MaChatLieu, TenChatLieu) " +
                "VALUES ('"+_chatlieu.Machatlieu+"',N'"+ _chatlieu.Tenchatlieu + "')";
            return db.ExecuteNonQuery(query);
        }
        public bool update(chatlieu _chatlieu)
        {
            string query = "UPDATE `chatlieu`" +
                " SET `MaChatLieu`='"+_chatlieu.Machatlieu+"',`TenChatLieu`=N'"+_chatlieu.Tenchatlieu+"' " +
                "WHERE id = "+_chatlieu.Id;
            return db.ExecuteNonQuery(query);
        }
        public bool delete(int id)
        {
            string query = "DELETE FROM `chatlieu` WHERE id = "+id;
            return db.ExecuteNonQuery(query);
        }
    }
}
