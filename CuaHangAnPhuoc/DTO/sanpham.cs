using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class sanpham
    {
        int id;
        string masanpham, tensanpham, uri, hinhanh, motangan, motadai;
        int soluong;
        double giagoc, giaban;
        bool ngunghoatdong, moira, dacsac;
        string loaisanpham, mausac, size, chatlieu, kieudang;
        bool enable, popular;
        public sanpham() { }
        public sanpham( int id, string masanpham, string tensanpham, string uri, string hinhanh, string motangan, string motadai, int soluong, double giagoc, double giaban, bool ngunghoatdong, bool moira, bool dacsac, string loaisanpham, string mausac, string size, string chatlieu, string kieudang, bool enable, bool popular)
        {
            Id = id;
            Masanpham = masanpham;
            Tensanpham = tensanpham;
            Uri = uri;
            Hinhanh = hinhanh;
            Motangan = motangan;
            Motadai = motadai;
            Soluong = soluong;
            Giagoc = giagoc;
            Giaban = giaban;
            Ngunghoatdong = ngunghoatdong;
            Moira = moira;
            Dacsac = dacsac;
            Loaisanpham = loaisanpham;
            Mausac = mausac;
            Size = size;
            Chatlieu = chatlieu;
            Kieudang = kieudang;
            Enable = enable;
            Popular = popular;
        }


        public int Id { get => id; set => id = value; }
        public string Masanpham { get => masanpham; set => masanpham = value; }
        public string Tensanpham { get => tensanpham; set => tensanpham = value; }
        public string Uri { get => uri; set => uri = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public string Motangan { get => motangan; set => motangan = value; }
        public string Motadai { get => motadai; set => motadai = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double Giagoc { get => giagoc; set => giagoc = value; }
        public double Giaban { get => giaban; set => giaban = value; }
        public bool Ngunghoatdong { get => ngunghoatdong; set => ngunghoatdong = value; }
        public bool Moira { get => moira; set => moira = value; }
        public bool Dacsac { get => dacsac; set => dacsac = value; }
        public string Loaisanpham { get => loaisanpham; set => loaisanpham = value; }
        public string Mausac { get => mausac; set => mausac = value; }
        public string Size { get => size; set => size = value; }
        public string Chatlieu { get => chatlieu; set => chatlieu = value; }
        public string Kieudang { get => kieudang; set => kieudang = value; }
        public bool Enable { get => enable; set => enable = value; }
        public bool Popular { get => popular; set => popular = value; }
    }
}
