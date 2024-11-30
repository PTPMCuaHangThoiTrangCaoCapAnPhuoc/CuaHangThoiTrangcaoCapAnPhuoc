using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLdonhang
    {
        DALdonhang dal;
        public BLLdonhang(string connectString)
        {
            dal = new DALdonhang(connectString);
        }
        public bool taoDonHang(donhang _donhang)
        {
            return dal.insert(_donhang);
        }
        public bool taoDonHangDonGian(donhang _donhang)
        {
            return dal.insertDonGian(_donhang);
        }
        public bool taoDonHangDonGianKhongKhachHang(donhang _donhang)
        {
            return dal.insertDonGianKhongKhachHang(_donhang);
        }
        public int getIdDhCuoiCung()
        {
            DataTable dt = dal.load();
            int maxId = dt.AsEnumerable().Max(row => row.Field<int>("id"));
            return maxId;
        }
        public bool huyDonHang(int id)
        {
            return dal.delete(id);
        }
    }
}
