using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Notification : BaseEntity
    {
        public string Description { get; set; }

        public string? Reason { get; set; }

        public Guid ApplictionId { get; set; }
        public Application Application { get; set; }

        public Guid UserOwnerId { get; set; }
        public User UserOwner { get; set; }


    }
}
