using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLuser
    {
        DALuser dal;
        public BLLuser(string connectString)
        {
            dal = new DALuser(connectString);
        }
    }
}
