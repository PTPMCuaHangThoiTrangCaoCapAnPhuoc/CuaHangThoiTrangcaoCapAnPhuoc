using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALkhachhang
    {
        DatabaseAccessLayer db;

        public DALkhachhang(string connectionString)
        {
            db = new DatabaseAccessLayer(connectionString);
        }
        public DataTable load()
        {
            string query = "SELECT * FROM khachhang";
            DataTable dt = new DataTable();
            dt = db.ExecuteQuery(query);
            return dt;
        }
        public bool insert(khachhang _khachhang)
        {
            string query = "INSERT INTO `khachhang`( `MaKhachHang`, `password`, `TenKhachHang`, `email`, `NgaySinh`, `DiaChi`)" +
                " VALUES ('"+_khachhang.Makhachhang+"', '"+_khachhang.Password+"', N'"+_khachhang.Tankhachhang+"', '"+_khachhang.Email+"', '"+_khachhang.Ngaysinh.ToString("yyyy-MM-dd")+"', N'"+_khachhang.Diachi+"')";
            return db.ExecuteNonQuery(query);
        }
        public bool update(khachhang _khachhang)
        {
            string query = "UPDATE `khachhang`" +
                " SET `MaKhachHang`='"+_khachhang.Makhachhang+"',`password`='"+_khachhang.Password+"',`TenKhachHang`=N'"+_khachhang.Tankhachhang+"',`email`='"+_khachhang.Email+"',`NgaySinh`='"+_khachhang.Ngaysinh.ToString("yyyy-MM-dd")+"',`DiaChi`=N'"+_khachhang.Diachi+"'" +
                " WHERE `id`="+_khachhang.Id;
            return db.ExecuteNonQuery(query);
        }
        public bool delete(int id)
        {
            string query = "DELETE FROM `khachhang` WHERE id = "+id;
            return db.ExecuteNonQuery(query);
        }
    }
}
