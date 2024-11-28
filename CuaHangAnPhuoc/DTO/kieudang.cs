using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class kieudang
    {
        int id;
        string makieudang, tenkieudang;
        public kieudang() { }
        public kieudang(int id, string makieudang, string tenkieudang)
        {
            Id = id;
            Makieudang = makieudang;
            Tenkieudang = tenkieudang;
        }

        public int Id { get => id; set => id = value; }
        public string Makieudang { get => makieudang; set => makieudang = value; }
        public string Tenkieudang { get => tenkieudang; set => tenkieudang = value; }
    }
}
