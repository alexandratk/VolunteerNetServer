using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class NotificationCreationModel
    {
        public Guid ApplicationId { get; set; }

        public Guid? UserRecipientId { get; set; }

        public string? Type { get; set; }

        public string Reason { get; set; }
    }
}
