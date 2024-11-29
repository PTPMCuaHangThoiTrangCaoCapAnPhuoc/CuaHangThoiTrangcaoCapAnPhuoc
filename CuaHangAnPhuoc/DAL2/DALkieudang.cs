using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALkieudang
    {
        DatabaseAccessLayer db;

        public DALkieudang(string connectionString)
        {
            db = new DatabaseAccessLayer(connectionString);
        }
        public DataTable load()
        {
            string query = "SELECT * FROM kieudang";
            DataTable dt = new DataTable();
            dt = db.ExecuteQuery(query);
            return dt;
        }
        public bool insert(kieudang _kieudang)
        {
            string query = "INSERT INTO `kieudang`( `MaKieuDang`, `TenKieuDang`)" +
                " VALUES ('"+_kieudang.Makieudang+"', N'"+_kieudang.Tenkieudang+"')";
            return db.ExecuteNonQuery(query);
        }
        public bool update(kieudang _kieudang)
        {
            string query = "UPDATE `kieudang` " +
                "SET `MaKieuDang`='"+_kieudang.Makieudang+"',`TenKieuDang`=N'"+_kieudang.Tenkieudang+"' " +
                "WHERE `id`="+_kieudang.Id;
            return db.ExecuteNonQuery(query);
        }
        public bool delete(int id)
        {
            string query = "DELETE FROM `kieudang` WHERE id = "+id;
            return db.ExecuteNonQuery(query);
        }
    }
}
