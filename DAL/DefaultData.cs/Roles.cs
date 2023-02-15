using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DefaultData.cs
{
    public static class Roles
    {
        public static List<string> ListRoles { get; set; } =
            new List<string>() { "user", "admin", "moderator" };
    }
}
