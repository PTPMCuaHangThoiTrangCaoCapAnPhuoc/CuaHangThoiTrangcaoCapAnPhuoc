using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLloaisanpham
    {
        DALloaisanpham dal;
        public BLLloaisanpham(string connectString)
        {
            dal = new DALloaisanpham(connectString);
        }
    }
}
