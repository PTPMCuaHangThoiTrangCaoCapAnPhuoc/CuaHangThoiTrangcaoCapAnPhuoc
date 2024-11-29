using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALsize
    {
        DatabaseAccessLayer db;

        public DALsize(string connectionString)
        {
            db = new DatabaseAccessLayer(connectionString);
        }
        public DataTable load()
        {
            string query = "SELECT * FROM size";
            DataTable dt = new DataTable();
            dt = db.ExecuteQuery(query);
            return dt;
        }
        public bool insert(size _size)
        {
            string query = "INSERT INTO `size`( `MaSize`, `TenSize`) VALUES ('"+_size.Masize+"', N'"+_size.Tensize+"')";
            return db.ExecuteNonQuery(query);
        }
        public bool update(size _size)
        {
            string query = "UPDATE `size` SET`MaSize`='"+_size.Masize+"',`TenSize`=N'"+_size.Tensize+"' WHERE  `id`="+_size.Id;
            return db.ExecuteNonQuery(query);
        }
        public bool delete(int id)
        {
            string query = "DELETE FROM `size` WHERE id = "+id;
            return db.ExecuteNonQuery(query);
        }
    }
}
