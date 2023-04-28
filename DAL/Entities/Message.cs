using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Message : BaseEntity
    {
        public string Text { get; set; }

        public Guid VolunteerId { get; set; }
        public Volunteer Volunteer { get; set; }

        public Guid VolunteerApplicationId { get; set; }

        public Guid VolunteerUserId { get; set; }
    }
}
