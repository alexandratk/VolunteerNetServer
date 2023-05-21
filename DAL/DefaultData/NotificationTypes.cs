using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DefaultData
{
    public static class NotificationTypes
    {
        public enum TypesEnum
        {
            ApproveApplication = 0,
            ForbidApplication = 1,
            Moderator = 2
        }

        public static List<string> Types { get; set; }
            = new List<string>() { "approveApplication", "forbidApplication", "moderator" };
    }
}
