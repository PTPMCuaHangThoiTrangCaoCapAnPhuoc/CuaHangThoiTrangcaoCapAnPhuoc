using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class donhang
    {
        int id;
        string makhachhang;
        DateTime ngaydathang;
        string diachiship;
        double tongien;
        DateTime ngayxacnhan, ngayxoa;
        public donhang() { }
        public donhang( int id, string makhachhang, DateTime ngaydathang, string diachiship, double tongien, DateTime ngayxacnhan, DateTime ngayxoa)
        {
            Id = id;
            Makhachhang = makhachhang;
            Ngaydathang = ngaydathang;
            Diachiship = diachiship;
            Tongien = tongien;
            Ngayxacnhan = ngayxacnhan;
            Ngayxoa = ngayxoa;
        }

        public int Id { get => id; set => id = value; }
        public string Makhachhang { get => makhachhang; set => makhachhang = value; }
        public DateTime Ngaydathang { get => ngaydathang; set => ngaydathang = value; }
        public string Diachiship { get => diachiship; set => diachiship = value; }
        public double Tongien { get => tongien; set => tongien = value; }
        public DateTime Ngayxacnhan { get => ngayxacnhan; set => ngayxacnhan = value; }
        public DateTime Ngayxoa { get => ngayxoa; set => ngayxoa = value; }
    }
}
