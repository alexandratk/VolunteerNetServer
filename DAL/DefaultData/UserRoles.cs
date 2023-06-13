using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DefaultData
{
    public static class UserRoles
    {
        public enum RolesEnum
        {
            User = 0,
            Admin = 1,
            Moderator = 2
        }

        public static List<string> Roles { get; set; } 
            = new List<string>() { "user", "admin", "moderator"};

        public static List<string> RolesUk { get; set; }
            = new List<string>() { "користувач", "адміністратор", "модератор" };

        public static List<string> RolesPl { get; set; }
            = new List<string>() { "użytkownik", "administrator", "moderator" };
    }
}
