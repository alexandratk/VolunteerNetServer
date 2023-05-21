using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Notification : BaseEntity
    {
        public string Type { get; set; }

        public string? Reason { get; set; }

        public Guid ApplictionId { get; set; }
        public Application Application { get; set; }

        public Guid UserSenderId { get; set; }
        public User UserSender { get; set; }

        public Guid UserRecipientId { get; set; }
        public User UserRecipient { get; set; }
    }
}
