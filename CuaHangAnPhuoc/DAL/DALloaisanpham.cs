using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALloaisanpham
    {
        DatabaseAccessLayer db;

        public DALloaisanpham(string connectionString)
        {
            db = new DatabaseAccessLayer(connectionString);
        }
        public DataTable load()
        {
            string query = "SELECT * FROM loaisanpham";
            DataTable dt = new DataTable();
            dt = db.ExecuteQuery(query);
            return dt;
        }
        public bool insert(loaisanpham _loaisanpham)
        {
            string query = "INSERT INTO `loaisanpham`( `MaLoai`, `TenLoai`, `MoTa`, `DanhMucSanPham`) " +
                "VALUES ('"+_loaisanpham.Maloai+"', N'"+_loaisanpham.Tenloai+"', N'"+_loaisanpham.Mota+"', '"+_loaisanpham.Danhmucsanpham+"')";
            return db.ExecuteNonQuery(query);
        }
        public bool update(loaisanpham _loaisanpham)
        {
            string query = "UPDATE `loaisanpham` " +
                "SET `MaLoai`='"+_loaisanpham.Maloai+"',`TenLoai`=N'"+_loaisanpham.Tenloai+"',`MoTa`=N'"+_loaisanpham.Mota+"',`DanhMucSanPham`='"+_loaisanpham.Danhmucsanpham+"'" +
                " WHERE `id`="+_loaisanpham.Id;
            return db.ExecuteNonQuery(query);
        }
        public bool delete(int id)
        {
            string query = "DELETE FROM `loaisanpham` WHERE id = "+id;
            return db.ExecuteNonQuery(query);
        }
    }
}
