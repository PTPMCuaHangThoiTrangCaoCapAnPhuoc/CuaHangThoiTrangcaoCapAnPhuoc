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
    public class BLLloaisanpham
    {
        DALloaisanpham dal;
        public BLLloaisanpham(string connectString)
        {
            dal = new DALloaisanpham(connectString);
        }
        public DataTable getAll()
        {
            DataTable dt = dal.load();
            return dt;
        }
        public List<string> GetLoaiLienQuan(string _maloai)
        {
            List<string> result = new List<string>(); // Danh sách chứa kết quả các MaLoai liên quan

            // Lấy tất cả dữ liệu
            DataTable dt = getAll();

            // Gọi hàm đệ quy để tìm MaLoai và các con của nó
            FindSubCategories(dt, _maloai, result);

            return result;
        }

        // Hàm đệ quy tìm MaLoai và các con của nó
         void FindSubCategories(DataTable dt, string maloai, List<string> result)
        {
            // Thêm MaLoai vào kết quả
            result.Add(maloai);

            // Tìm các dòng có DanhMucSanPham tham chiếu đến MaLoai hiện tại
            foreach (DataRow row in dt.Rows)
            {
                // Kiểm tra nếu dòng có DanhMucSanPham tham chiếu đến MaLoai
                if (row["DanhMucSanPham"] != DBNull.Value && row["DanhMucSanPham"].ToString() == maloai)
                {
                    string childMaLoai = row["MaLoai"].ToString();
                    // Đệ quy tiếp để tìm các con của MaLoai này
                    FindSubCategories(dt, childMaLoai, result);
                }
            }
        }
    }
}
