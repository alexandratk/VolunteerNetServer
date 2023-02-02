using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Helpers
{
    public class AuthOptions
    {
        public const string ISSUER = "MyAuthServer"; // token publisher
        public const string AUDIENCE = "MyAuthClient"; // token consumer
        const string KEY = "mysupersecret_secretkey!123";   // encryption key
        public const int LIFETIME = 60; // token lifetime - 60 minutes
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
