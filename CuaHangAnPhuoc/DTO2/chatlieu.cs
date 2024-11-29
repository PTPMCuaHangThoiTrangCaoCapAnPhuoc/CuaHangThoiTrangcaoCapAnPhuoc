using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class chatlieu
    {
        int id;
        string machatlieu, tenchatlieu;
        public chatlieu() { }
        public chatlieu(int id, string machatlieu, string tenchatlieu)
        {
            Id = id;
            Machatlieu = machatlieu;
            Tenchatlieu = tenchatlieu;
        }

        public int Id { get => id; set => id = value; }
        public string Machatlieu { get => machatlieu; set => machatlieu = value; }
        public string Tenchatlieu { get => tenchatlieu; set => tenchatlieu = value; }
    }
}
