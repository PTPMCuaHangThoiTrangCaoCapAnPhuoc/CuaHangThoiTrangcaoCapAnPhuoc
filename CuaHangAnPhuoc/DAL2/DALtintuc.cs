using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALtintuc
    {
        DatabaseAccessLayer db;

        public DALtintuc(string connectionString)
        {
            db = new DatabaseAccessLayer(connectionString);
        }
        public DataTable load()
        {
            string query = "SELECT * FROM tintuc";
            DataTable dt = new DataTable();
            dt = db.ExecuteQuery(query);
            return dt;
        }
        public bool insert(tintuc _tintuc)
        {
            string query = "INSERT INTO `tintuc`( `MaTinTuc`, `TenTinTuc`, `NoiDung`, `NgayDang`, `HinhAnhDaiDien`, `enable`, `popular`)" +
                " VALUES ('"+_tintuc.Matintuc+"', N'"+_tintuc.Tentintuc+"', N'"+_tintuc.Noidung+"', '"+_tintuc.Ngaydang.ToString("yyyy-MM-dd")+"', '"+_tintuc.Hinhanhdaidien+"',"+_tintuc.Enable+" ,"+_tintuc.Popular+" )";
            return db.ExecuteNonQuery(query);
        }
        public bool update(tintuc _tintuc)
        {
            string query = "UPDATE `tintuc` " +
                "SET `MaTinTuc`='"+_tintuc.Matintuc+"',`TenTinTuc`=N'"+_tintuc.Tentintuc+"',`NoiDung`=N'"+_tintuc.Noidung+"',`NgayDang`='"+_tintuc.Ngaydang+"',`HinhAnhDaiDien`='"+_tintuc.Hinhanhdaidien+"',`enable`="+_tintuc.Enable+",`popular`= "+_tintuc.Popular+"" +
                "WHERE  `id`=" + _tintuc.Id;
            return db.ExecuteNonQuery(query);
        }
        public bool delete(int id)
        {
            string query = "DELETE FROM `tintuc` WHERE id = "+id;
            return db.ExecuteNonQuery(query);
        }
    }
}
