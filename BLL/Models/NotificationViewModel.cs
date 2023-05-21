using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class NotificationViewModel : BaseModel
    {
        public string Type { get; set; }

        public string? Reason { get; set; }

        public ApplicationViewModel Application { get; set; }

        public UserViewModel UserSender { get; set; }

        public UserViewModel UserRecipient { get; set; }
    }
}
