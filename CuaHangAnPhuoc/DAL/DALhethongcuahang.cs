using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALhethongcuahang
    {
        DatabaseAccessLayer db;

        public DALhethongcuahang(string connectionString)
        {
            db = new DatabaseAccessLayer(connectionString);
        }
        public DataTable load()
        {
            string query = "SELECT * FROM hethongcuahang";
            DataTable dt = new DataTable();
            dt = db.ExecuteQuery(query);
            return dt;
        }
        public bool insert(hethongcuahang _hethongcuahang)
        {
            string query = "INSERT INTO `hethongcuahang`(`MaCuaHang`, `TenCuaHang`, `SoNha`, `PhuongXa`, `QuanHuyen`, `TinhThanhPho`) " +
                "VALUES ('"+_hethongcuahang.Macuahang+"', N'"+_hethongcuahang.Tencuahang+"', N'"+_hethongcuahang.Sonha+"', N'"+_hethongcuahang.Phuongxa+"', N'"+_hethongcuahang.Quanhuyen+"', N'"+_hethongcuahang.Tinhthanhpho+"')";
            return db.ExecuteNonQuery(query);
        }
        public bool update(hethongcuahang _hethongcuahang)
        {
            string query = "UPDATE `hethongcuahang` " +
                "SET `TenCuaHang`=N'"+_hethongcuahang.Tencuahang+"',`SoNha`=N'"+_hethongcuahang.Sonha+"',`PhuongXa`=N'"+_hethongcuahang.Phuongxa+"',`QuanHuyen`=N'"+_hethongcuahang.Quanhuyen+"',`TinhThanhPho`=N'"+_hethongcuahang.Tinhthanhpho+"' " +
                "WHERE `MaCuaHang`='"+_hethongcuahang.Macuahang+"'";
            return db.ExecuteNonQuery(query);
        }
        public bool delete(string macuahang)
        {
            string query = "DELETE FROM `hethongcuahang` WHERE MaCuaHang = '"+macuahang+"' ";
            return db.ExecuteNonQuery(query);
        }
    }
}
