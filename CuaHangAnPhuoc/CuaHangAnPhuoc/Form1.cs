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

namespace CuaHangAnPhuoc
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=fashion;User ID=root;Password=;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kq="";
            try
            {
                // Tạo kết nối tới MySQL
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Kết nối thành công!");

                    // Ví dụ truy vấn dữ liệu
                    string query = "SELECT * FROM sanpham";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Đọc dữ liệu
                    while (reader.Read())
                    {
                       kq+=reader["TenSanPham"].ToString();
                    }

                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            label1.Text = kq;
        }
    }
}
