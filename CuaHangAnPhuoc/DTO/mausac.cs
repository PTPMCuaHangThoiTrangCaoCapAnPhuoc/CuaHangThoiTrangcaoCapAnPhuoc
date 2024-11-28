using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class mausac
    {
        int id;
        string mamausac, tenmausac, hexmausac;
        public mausac() { }
        public mausac(int id, string mamausac, string tenmausac, string hexmausac)
        {
            Id = id;
            Mamausac = mamausac;
            Tenmausac = tenmausac;
            Hexmausac = hexmausac;
        }

        public int Id { get => id; set => id = value; }
        public string Mamausac { get => mamausac; set => mamausac = value; }
        public string Tenmausac { get => tenmausac; set => tenmausac = value; }
        public string Hexmausac { get => hexmausac; set => hexmausac = value; }
    }
}
