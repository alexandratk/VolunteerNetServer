using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class AuthRequestModel
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public AuthRequestModel(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
