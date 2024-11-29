using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLimage
    {
        DALimage dal;
        public BLLimage(string connectString)
        {
            dal = new DALimage(connectString);
        }
    }
}
