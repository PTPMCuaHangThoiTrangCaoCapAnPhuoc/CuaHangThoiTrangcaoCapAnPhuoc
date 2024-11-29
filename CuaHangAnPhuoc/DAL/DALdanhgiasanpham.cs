using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALdanhgiasanpham
    {
        DatabaseAccessLayer db;

        public DALdanhgiasanpham(string connectionString)
        {
            db = new DatabaseAccessLayer(connectionString);
        }
        public DataTable load()
        {
            string query = "SELECT * FROM danhgiasanpham";
            DataTable dt = new DataTable();
            dt = db.ExecuteQuery(query);
            return dt;
        }
        public bool insert(danhgiasanpham _danhgiasanpham)
        {
            string query = "INSERT INTO `danhgiasanpham`(`MaSanPham`, `MaKhachHang`, `DanhGia`, `XepHang`, `NgayDanhGia`)" +
                " VALUES ('"+_danhgiasanpham.Masanpham+"', '"+_danhgiasanpham.Makhachhang+"', N'"+_danhgiasanpham.Danhgia+"',"+_danhgiasanpham.Xephang+" , '"+_danhgiasanpham.Ngaydanhgia.ToString("yyyy-MM-dd")+"')";
            return db.ExecuteNonQuery(query);
        }
        public bool update(danhgiasanpham _danhgiasanpham)
        {
            string query = "UPDATE `danhgiasanpham` " +
                "SET `DanhGia`=N'"+_danhgiasanpham.Danhgia+"',`XepHang`="+_danhgiasanpham.Danhgia+",`NgayDanhGia`='"+_danhgiasanpham.Ngaydanhgia.ToString("yyyy-MM-dd")+"'" +
                " WHERE `MaSanPham`='"+_danhgiasanpham.Masanpham+"',`MaKhachHang`='"+_danhgiasanpham.Makhachhang+"'";
            return db.ExecuteNonQuery(query);
        }
        public bool delete(string Masanpham, string Makhachhang)
        {
            string query = "DELETE FROM `danhgiasanpham`" +
                " WHERE `MaSanPham`='" + Masanpham + "',`MaKhachHang`='" +Makhachhang + "'";
            return db.ExecuteNonQuery(query);
        }
    }
}
