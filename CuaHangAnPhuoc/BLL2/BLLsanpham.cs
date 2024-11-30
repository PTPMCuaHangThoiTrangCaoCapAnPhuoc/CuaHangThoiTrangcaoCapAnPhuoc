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
        public DataTable getDayDu()
        {
            DataTable dt = dal.selectDayDu();
            return dt;
        }
        public DataTable GetProductsByLoai(List<string> lstLoai)
        {
            DataTable dt = dal.selectDayDu();
            DataTable filteredData = dt.Clone(); // Tạo DataTable mới với cấu trúc giống `dt`

            foreach (DataRow row in dt.Rows)
            {
                foreach (string item in lstLoai)
                {
                    if (row["LoaiSanPham"].ToString().Equals(item))
                    {
                        filteredData.ImportRow(row);
                    }
                }
                
            }

            return filteredData;
        }
        public bool updateSoLuong(int id, int sl)
        {
            return dal.updateSoLuong(id, sl);
        }
    }
}
