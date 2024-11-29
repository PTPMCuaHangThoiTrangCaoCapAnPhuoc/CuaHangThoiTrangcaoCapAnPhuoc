using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALdonhang
    {
        DatabaseAccessLayer db;

        public DALdonhang(string connectionString)
        {
            db = new DatabaseAccessLayer(connectionString);
        }
        public DataTable load()
        {
            string query = "SELECT * FROM donhang";
            DataTable dt = new DataTable();
            dt = db.ExecuteQuery(query);
            return dt;
        }
        public bool insert(donhang _donhang)
        {
            string query = "INSERT INTO `donhang`( `MaKhachHang`, `NgayDatHang`, `DiaChiShip`, `TongTien`, `NgayXacNhan`, `NgayXoa`) " +
                "VALUES ('"+_donhang.Makhachhang+"', '"+_donhang.Ngaydathang.ToString("yyyy-MM-dd")+"', N'"+_donhang.Diachiship+"',"+_donhang.Tongien+" , '"+_donhang.Ngayxacnhan.ToString("yyyy-MM-dd")+"', '"+_donhang.Ngayxoa.ToString("yyyy-MM-dd")+"')";
            return db.ExecuteNonQuery(query);
        }
        public bool update(donhang _donhang)
        {
            string query = "UPDATE `donhang` " +
                "SET `MaKhachHang`='"+_donhang.Makhachhang+"',`NgayDatHang`='" + _donhang.Ngaydathang.ToString("yyyy-MM-dd") + "',`DiaChiShip`=N'" + _donhang.Diachiship + "',`TongTien`=" + _donhang.Tongien + ",`NgayXacNhan`='" + _donhang.Ngayxacnhan.ToString("yyyy-MM-dd") + "',`NgayXoa`='" + _donhang.Ngayxoa.ToString("yyyy-MM-dd") + "'" +
                " WHERE `id`="+_donhang.Id;
            return db.ExecuteNonQuery(query);
        }
        public bool delete(int id)
        {
            string query = "DELETE FROM `donhang` WHERE id = " +id;
            return db.ExecuteNonQuery(query);
        }
    }
}
