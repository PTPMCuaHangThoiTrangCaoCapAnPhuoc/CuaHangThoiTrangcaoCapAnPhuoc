using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLsanpham
    {
        DALsanpham dal;
        public BLLsanpham(string connectString)
        {
            dal = new DALsanpham(connectString);
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            dt = dal.load();
            return dt;
        }
    }
}
