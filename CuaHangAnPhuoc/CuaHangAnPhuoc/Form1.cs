using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DTO;
using BLL;
using System.Configuration;

namespace CuaHangAnPhuoc
{
    public partial class Form1 : Form
    {
        // Đường dẫn database lưu trong App.config, gọi ra lưu connectionString cho tiện.
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kq = "";
            BLLsanpham bLLsanpham = new BLLsanpham(connectionString);   // Tương tác gì thì gọi BLL của cái đó
            DataTable dt = bLLsanpham.getAll();                         // Muốn xử lí gì thì vô BLL xử lý
                                                                        // DAL có các hàm load, insert, update, delete
            // Kiểm tra nếu có dữ liệu
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                kq = "Có " + dt.Rows.Count + " sản phẩm";
            }
            else
            {
                dataGridView1.DataSource = null; // Không có dữ liệu
                kq = "Không có sản phẩm nào";
            }

            // Hiển thị kết quả vào label1
            label1.Text = kq;

        }
    }
}
