using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class khachhang
    {
        int id;
        string makhachhang, tankhachhang, password, email;
        DateTime ngaysinh;
        string diachi;
        List<string> sodienthoai;
        public khachhang() { }
        public khachhang( int id, string makhachhang, string tankhachhang, string password, string email, DateTime ngaysinh, string diachi, List<string> sodienthoai)
        {
            Id = id;
            Makhachhang = makhachhang;
            Tankhachhang = tankhachhang;
            Password = password;
            Email = email;
            Ngaysinh = ngaysinh;
            Diachi = diachi;
            Sodienthoai = sodienthoai;
        }

        public int Id { get => id; set => id = value; }
        public string Makhachhang { get => makhachhang; set => makhachhang = value; }
        public string Tankhachhang { get => tankhachhang; set => tankhachhang = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public List<string> Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
    }
}
