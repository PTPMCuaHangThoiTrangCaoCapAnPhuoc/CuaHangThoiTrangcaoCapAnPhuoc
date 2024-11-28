using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tintuc
    {
        int id;
        string matintuc, tentintuc, noidung, ngaydang, hinhanhdaidien;
        bool enable, popular;
        public tintuc() { }
        public tintuc(int id, string matintuc, string tentintuc, string noidung, string ngaydang, string hinhanhdaidien, bool enable, bool popular)
        {
            Id = id;
            Matintuc = matintuc;
            Tentintuc = tentintuc;
            Noidung = noidung;
            Ngaydang = ngaydang;
            Hinhanhdaidien = hinhanhdaidien;
            Enable = enable;
            Popular = popular;
        }

        public int Id { get => id; set => id = value; }
        public string Matintuc { get => matintuc; set => matintuc = value; }
        public string Tentintuc { get => tentintuc; set => tentintuc = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string Ngaydang { get => ngaydang; set => ngaydang = value; }
        public string Hinhanhdaidien { get => hinhanhdaidien; set => hinhanhdaidien = value; }
        public bool Enable { get => enable; set => enable = value; }
        public bool Popular { get => popular; set => popular = value; }
    }
}
