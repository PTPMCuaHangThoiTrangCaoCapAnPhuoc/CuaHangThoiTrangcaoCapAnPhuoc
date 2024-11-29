using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLchatlieu
    {
        DALchatlieu dal;
        public BLLchatlieu(string connectString)
        {
            dal = new DALchatlieu(connectString);
        }
    }
}
