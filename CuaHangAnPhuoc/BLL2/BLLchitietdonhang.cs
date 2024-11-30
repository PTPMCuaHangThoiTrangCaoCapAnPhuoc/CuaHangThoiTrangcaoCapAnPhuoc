using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLchitietdonhang
    {
        DALchitietdonhang dal;
        public BLLchitietdonhang(string connectString)
        {
            dal = new DALchitietdonhang(connectString);
        }
        public bool themCTDH(chitietdonhang _chitietdonhang)
        {
            return dal.insert(_chitietdonhang);
        }
    }
}
