using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class video
    {
        int id;
        string url, type;
        public video() { }
        public video( int id, string url, string type)
        {
            Id = id;
            Url = url;
            Type = type;
        }

        public int Id { get => id; set => id = value; }
        public string Url { get => url; set => url = value; }
        public string Type { get => type; set => type = value; }
    }
}
