using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class image
    {
        int id;
        string title, url;
        bool enable;
        string type;
        int product_id;
        public image() { }
        public image (int id, string title, string url, bool enable, string type, int product_id)
        {
            Id = id; Title = title; Url = url; Enable = enable; Type = type; Product_id = product_id;
        }

        public int Product_id { get => product_id; set => product_id = value; }
        public string Type { get => type; set => type = value; }
        public bool Enable { get => enable; set => enable = value; }
        public string Title { get => title; set => title = value; }
        public string Url { get => url; set => url = value; }
        public int Id { get => id; set => id = value; }
    }
}
