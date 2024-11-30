using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALchitietdonhang
    {
        DatabaseAccessLayer db;

        public DALchitietdonhang(string connectionString)
        {
            db = new DatabaseAccessLayer(connectionString);
        }
        public DataTable load()
        {
            string query = "SELECT * FROM chitietdonhang";
            DataTable dt = new DataTable();
            dt = db.ExecuteQuery(query);
            return dt;
        }
        public bool insert(chitietdonhang _chitietdonhang)
        {
            string query = "INSERT INTO `chitietdonhang`(`MaDonHang`, `MaSanPham`, `SoLuong`, `DonGia`)" +
                " VALUES ("+_chitietdonhang.Madonhang+" ,'"+_chitietdonhang.Masanpham+"',"+_chitietdonhang.Soluong+" ,"+_chitietdonhang.Dongia+" )";
            return db.ExecuteNonQuery(query);
        }
        public bool update(chitietdonhang _chitietdonhang)
        {
            string query = "UPDATE `chitietdonhang` " +
                "SET `MaSanPham`="+_chitietdonhang.Masanpham+",`SoLuong`="+_chitietdonhang.Soluong+",`DonGia`= " + _chitietdonhang.Dongia+
                "WHERE `MaDonHang`=" + _chitietdonhang.Madonhang;
            return db.ExecuteNonQuery(query);
        }
        public bool delete(int id)
        {
            string query = "DELETE FROM `chitietdonhang` WHERE MaDonHang = " + id;
            return db.ExecuteNonQuery(query);
        }
    }
}
