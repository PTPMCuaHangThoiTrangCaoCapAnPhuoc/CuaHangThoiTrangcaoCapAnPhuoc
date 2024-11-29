using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLtintuc
    {
        DALtintuc dal;
        public BLLtintuc(string connectString)
        {
            dal = new DALtintuc(connectString);
        }
    }
}
