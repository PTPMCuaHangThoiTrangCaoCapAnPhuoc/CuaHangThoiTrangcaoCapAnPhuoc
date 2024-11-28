using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class loaisanpham
    {
        int id;
        string maloai, tenloai, mota;
        string danhmucsanpham;
        public loaisanpham() { }
        public loaisanpham(int id, string maloai, string tenloai, string mota, string danhmucloai)
        {
            Id = id;Maloai = maloai;Tenloai = tenloai;Mota = mota;Danhmucsanpham = danhmucloai;
        }

        
        public string Maloai { get => maloai; set => maloai = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
        public string Mota { get => mota; set => mota = value; }
        public int Id { get => id; set => id = value; }
        public string Danhmucsanpham { get => danhmucsanpham; set => danhmucsanpham = value; }
    }
}
