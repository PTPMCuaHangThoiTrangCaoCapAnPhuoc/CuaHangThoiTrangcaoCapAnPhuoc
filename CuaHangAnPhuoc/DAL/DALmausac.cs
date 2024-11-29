using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALmausac
    {
        DatabaseAccessLayer db;

        public DALmausac(string connectionString)
        {
            db = new DatabaseAccessLayer(connectionString);
        }
        public DataTable load()
        {
            string query = "SELECT * FROM mausac";
            DataTable dt = new DataTable();
            dt = db.ExecuteQuery(query);
            return dt;
        }
        public bool insert(mausac _mausac)
        {
            string query = "INSERT INTO `mausac`( `MaMauSac`, `TenMauSac`, `HEXMauSac`)" +
                " VALUES ('"+_mausac.Mamausac+"', N'"+_mausac.Tenmausac+"', '"+_mausac.Hexmausac+"')";
            return db.ExecuteNonQuery(query);
        }
        public bool update(mausac _mausac)
        {
            string query = "UPDATE `mausac`" +
                " SET `MaMauSac`='"+_mausac.Mamausac+"',`TenMauSac`=N'"+_mausac.Tenmausac+"',`HEXMauSac`='"+_mausac.Hexmausac+"' " +
                "WHERE `id`="+_mausac.Id;
            return db.ExecuteNonQuery(query);
        }
        public bool delete(int id)
        {
            string query = "DELETE FROM `mausac` WHERE id = "+id;
            return db.ExecuteNonQuery(query);
        }
    }
}
