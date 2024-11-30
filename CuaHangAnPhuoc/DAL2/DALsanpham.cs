using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALsanpham
    {
        DatabaseAccessLayer db;

        public DALsanpham(string connectionString)
        {
            db = new DatabaseAccessLayer(connectionString);
        }
        public DataTable load()
        {
            string query = "SELECT * FROM sanpham";
            DataTable dt = new DataTable();
            dt = db.ExecuteQuery(query);
            return dt;
        }
        public bool insert(sanpham _sanpham)
        {
            string query = "INSERT INTO `sanpham`(`MaSanPham`, `TenSanPham`, `uri`, `HinhAnh`, `MoTaNgan`, `MotaDai`, `SoLuong`, `GiaGoc`, `GiaBan`, " +
                "`NgungHoatDong`, `MoiRa`, `DacSac`, `LoaiSanPham`, `MauSac`, `Size`, `ChatLieu`, `KieuDang`, `enable`, `popular`) " +
                "VALUES ('"+_sanpham.Masanpham+"', N'"+_sanpham.Tensanpham+"', '"+_sanpham.Uri+"', '"+_sanpham.Hinhanh+"', N'"+_sanpham.Motangan+"', N'"+_sanpham.Motadai+"',"+_sanpham.Soluong+" ,"+_sanpham.Giagoc+" ,"+_sanpham.Giaban+" ," +
                " "+_sanpham.Ngunghoatdong+","+_sanpham.Moira+" ,"+_sanpham.Dacsac+" , '"+_sanpham.Loaisanpham+"', '"+_sanpham.Mausac+"', '"+_sanpham.Size+"', '"+_sanpham.Chatlieu+"', '"+_sanpham.Kieudang+"', "+_sanpham.Enable+", "+_sanpham.Popular+" )";
            return db.ExecuteNonQuery(query);
        }
        public bool update(sanpham _sanpham)
        {
            string query = "UPDATE `sanpham` " +
                "SET `MaSanPham`='"+_sanpham.Masanpham+"',`TenSanPham`=N'"+_sanpham.Tensanpham+"',`uri`='"+_sanpham.Uri+"',`HinhAnh`='"+_sanpham.Hinhanh+"',`MoTaNgan`=N'"+_sanpham.Motangan+"',`MotaDai`=N'"+_sanpham.Motadai+"'," +
                "`SoLuong`="+_sanpham.Soluong+",`GiaGoc`="+_sanpham.Giagoc+",`GiaBan`="+_sanpham.Giaban+",`NgungHoatDong`="+_sanpham.Ngunghoatdong+"," +
                "`MoiRa`="+_sanpham.Moira+",`DacSac`="+_sanpham.Dacsac+",`LoaiSanPham`='"+_sanpham.Loaisanpham+"',`MauSac`='"+_sanpham.Mausac+"',`Size`='"+_sanpham.Size+"',`ChatLieu`='"+_sanpham.Chatlieu+"'," +
                "`KieuDang`='"+_sanpham.Kieudang+"',`enable`="+_sanpham.Enable+",`popular`="+_sanpham.Popular+" " +
                "WHERE `id`="+_sanpham.Id;
            return db.ExecuteNonQuery(query);
        }
        public bool delete(int id)
        {
            string query = "DELETE FROM `sanpham` WHERE id = "+id;
            return db.ExecuteNonQuery(query);
        }

        public DataTable selectDayDu()
        {
            string quyery = "SELECT sp.id, `MaSanPham`, `TenSanPham`, `HinhAnh`, `SoLuong`, `GiaBan`,l.TenLoai,ms.TenMauSac, size.TenSize, cl.TenChatLieu, kd.TenKieuDang, sp.LoaiSanPham " +
                "FROM `sanpham` sp, loaisanpham l, mausac ms, size, chatlieu cl, kieudang kd" +
                " WHERE sp.enable = true and sp.LoaiSanPham=l.MaLoai and sp.MauSac=ms.MaMauSac and sp.Size=size.MaSize and sp.ChatLieu=cl.MaChatLieu and sp.KieuDang=kd.MaKieuDang;";
            return db.ExecuteQuery(quyery);
        }

        public bool updateSoLuong(int id, int sl)
        {
            string query = "UPDATE `sanpham` SET`SoLuong`= SoLuong - "+sl+" WHERE id =" + id;
            return db.ExecuteNonQuery(query);
        }
    }
}
