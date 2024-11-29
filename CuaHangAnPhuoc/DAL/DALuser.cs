using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALuser
    {
        DatabaseAccessLayer db;

        public DALuser(string connectionString)
        {
            db = new DatabaseAccessLayer(connectionString);
        }
        public DataTable load()
        {
            string query = "SELECT * FROM user";
            DataTable dt = new DataTable();
            dt = db.ExecuteQuery(query);
            return dt;
        }
        public bool insert(user _user)
        {
            string query = "INSERT INTO `user`( `username`, `password`) VALUES ('"+_user.Username+"', '"+_user.Password+"')";
            return db.ExecuteNonQuery(query);
        }
        public bool update(user _user)
        {
            string query = "UPDATE `user` SET `username`='"+_user.Username+"',`password`='"+_user.Password+"' WHERE id = "+_user.Id;
            return db.ExecuteNonQuery(query);
        }
        public bool delete(int id)
        {
            string query = "DELETE FROM `user` WHERE id = "+id;
            return db.ExecuteNonQuery(query);
        }
    }
}
