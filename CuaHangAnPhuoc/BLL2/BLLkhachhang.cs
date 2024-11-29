using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLkhachhang
    {
        DALkhachhang dal;
        public BLLkhachhang(string connectString)
        {
            dal = new DALkhachhang(connectString);
        }
    }
}
