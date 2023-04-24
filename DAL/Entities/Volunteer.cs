using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Volunteer : BaseEntity
    {
        public User User { get; set; }
        public Guid UserId { get; set; }

        public Application Application { get; set; }
        public Guid ApplicationId { get; set; }

        public int Status { get; set; }
    }
}
