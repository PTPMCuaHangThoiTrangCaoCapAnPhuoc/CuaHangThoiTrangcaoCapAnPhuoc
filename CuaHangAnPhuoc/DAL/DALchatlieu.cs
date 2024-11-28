using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALchatlieu
    {
        private string connectionString;

        public DALchatlieu(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public DataTable load()
        {
            string query = "SELECT COUNT(*) FROM Products";
            
        }
    }
}
