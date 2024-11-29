using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLkieudang
    {
        DALkieudang dal;
        public BLLkieudang(string connectString)
        {
            dal = new DALkieudang(connectString);
        }
    }
}
