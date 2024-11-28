using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class hethongcuahang
    {
        string macuahang, tencuahang, sonha, phuongxa, quanhuyen, tinhthanhpho;
        public hethongcuahang() { }
        public hethongcuahang( string macuahang, string tencuahang, string sonha, string phuongxa, string quanhuyen, string tinhthanhpho)
        {
            Macuahang = macuahang;
            Tencuahang = tencuahang;
            Sonha = sonha;
            Phuongxa = phuongxa;
            Quanhuyen = quanhuyen;
            Tinhthanhpho = tinhthanhpho;
        }

        public string Macuahang { get => macuahang; set => macuahang = value; }
        public string Tencuahang { get => tencuahang; set => tencuahang = value; }
        public string Sonha { get => sonha; set => sonha = value; }
        public string Phuongxa { get => phuongxa; set => phuongxa = value; }
        public string Quanhuyen { get => quanhuyen; set => quanhuyen = value; }
        public string Tinhthanhpho { get => tinhthanhpho; set => tinhthanhpho = value; }
    }
}
