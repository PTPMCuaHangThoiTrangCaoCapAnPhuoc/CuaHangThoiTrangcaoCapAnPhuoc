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
    public class BLLuser
    {
        DALuser dal;
        public BLLuser(string connectString)
        {
            dal = new DALuser(connectString);
        }
        public bool dangnhap(string _username, string _password)
        {
            DataTable dt = dal.load();
            foreach (DataRow row in dt.Rows)
            {
                string username = (string)row["username"];
                string password = (string)row["password"];
                if (username.Equals(_username))
                {
                    if (password.Equals(_password))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
