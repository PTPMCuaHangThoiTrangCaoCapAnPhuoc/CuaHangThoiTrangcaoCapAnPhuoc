using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class danhgiasanpham
    {
        string masanpham, makhachhang, danhgia;
        int xephang;
        DateTime ngaydanhgia;
        public danhgiasanpham() { }
        public danhgiasanpham(string masanpham, string makhachhang, string danhgia, int xephang, DateTime ngaydanhgia)
        {
            Masanpham = masanpham;
            Makhachhang = makhachhang;
            Danhgia = danhgia;
            Xephang = xephang;
            Ngaydanhgia = ngaydanhgia;
        }

        public string Masanpham { get => masanpham; set => masanpham = value; }
        public string Makhachhang { get => makhachhang; set => makhachhang = value; }
        public string Danhgia { get => danhgia; set => danhgia = value; }
        public int Xephang { get => xephang; set => xephang = value; }
        public DateTime Ngaydanhgia { get => ngaydanhgia; set => ngaydanhgia = value; }
    }
}
