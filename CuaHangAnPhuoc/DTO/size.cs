using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class size
    {
        int id;
        string masize, tensize;
        public size() { }
        public size(int id, string masize, string tensize)
        {
            Id = id;
            Masize = masize;
            Tensize = tensize;
        }

        public int Id { get => id; set => id = value; }
        public string Masize { get => masize; set => masize = value; }
        public string Tensize { get => tensize; set => tensize = value; }
    }
}
