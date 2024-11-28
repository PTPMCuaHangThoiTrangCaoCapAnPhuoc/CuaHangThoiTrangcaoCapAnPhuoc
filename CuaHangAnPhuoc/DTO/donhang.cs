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
        string ngayxacnhan, ngayxoa;
        public donhang() { }
        public donhang( int id, string makhachhang, DateTime ngaydathang, string diachiship, double tongien, string ngayxacnhan, string ngayxoa)
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
        public string Ngayxacnhan { get => ngayxacnhan; set => ngayxacnhan = value; }
        public string Ngayxoa { get => ngayxoa; set => ngayxoa = value; }
    }
}
