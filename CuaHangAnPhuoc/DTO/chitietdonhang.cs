using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class chitietdonhang
    {
        int madonhang;
        string masanpham;
        int soluong;
        double dongia;
        public chitietdonhang() { }
        public chitietdonhang(int madonhang, string masanpham, int soluong, double dongia)
        {
            Madonhang = madonhang; Masanpham = masanpham; Soluong = soluong; Dongia = dongia;
        }

        public double Dongia { get => dongia; set => dongia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Madonhang { get => madonhang; set => madonhang = value; }
        public string Masanpham { get => masanpham; set => masanpham = value; }
    }
}
