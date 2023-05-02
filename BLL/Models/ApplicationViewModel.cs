using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ApplicationViewModel : BaseModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int StatusNumber { get; set; }

        public string Status { get; set; }

        public string Type { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public Guid CityId { get; set; }

        public int RequiredNumberOfVolunteers { get; set; }

        public int NumberOfVolunteers { get; set; }

        public Guid UserId { get; set; }

        public bool CheckVolunteer { get; set; }
    }
}
