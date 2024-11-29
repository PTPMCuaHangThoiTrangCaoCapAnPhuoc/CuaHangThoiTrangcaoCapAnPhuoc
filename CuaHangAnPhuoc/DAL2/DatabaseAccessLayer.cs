using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class DatabaseAccessLayer
    {
        private string connectionString;

        public DatabaseAccessLayer(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Phương thức mở kết nối tới MySQL
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Phương thức thực thi truy vấn SELECT và trả về DataTable
        public DataTable ExecuteQuery(string query)
        {
            DataTable result = new DataTable();
            using (MySqlConnection connection = GetConnection())
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                connection.Open();
                dataAdapter.Fill(result);
            }
            return result;
        }

        // Phương thức thực thi truy vấn INSERT, UPDATE, DELETE (Không trả về dữ liệu)
        public bool ExecuteNonQuery(string query)
        {
            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    connection.Open();
                    int affectedRows = command.ExecuteNonQuery();  // Lấy số lượng bản ghi bị ảnh hưởng
                    return affectedRows > 0;  // Nếu có bản ghi bị ảnh hưởng, trả về true
                }
            }
            catch (Exception ex)
            {
                // Log lỗi hoặc xử lý ngoại lệ nếu cần
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;  // Nếu có lỗi xảy ra, trả về false
            }
        }


        // Phương thức thực thi truy vấn và trả về một giá trị duy nhất (ví dụ: COUNT, SUM, v.v.)
        public object ExecuteScalar(string query)
        {
            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    connection.Open();
                    object result = command.ExecuteScalar();  // Trả về một giá trị duy nhất
                    return result ?? null;  // Nếu result là null, trả về null
                }
            }
            catch (Exception ex)
            {
                // Log lỗi hoặc xử lý ngoại lệ nếu cần
                Console.WriteLine($"Lỗi: {ex.Message}");
                return null;  // Nếu có lỗi xảy ra, trả về null
            }
        }

    }
}
