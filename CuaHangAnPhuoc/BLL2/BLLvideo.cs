using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLvideo
    {
        DALvideo dal;
        public BLLvideo(string connectString)
        {
            dal = new DALvideo(connectString);
        }
    }
}
