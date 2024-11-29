using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLsize
    {
        DALsize dal;
        public BLLsize(string connectString)
        {
            dal = new DALsize(connectString);
        }
    }
}
