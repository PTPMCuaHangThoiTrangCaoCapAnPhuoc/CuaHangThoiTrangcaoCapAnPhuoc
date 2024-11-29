using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class user
    {
        int id;
        string username, password;
        public user() { }
        public user( int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
