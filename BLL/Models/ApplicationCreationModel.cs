using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ApplicationCreationModel
    {
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public string Type { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public int RequiredNumberOfVolunteers { get; set; }

        public List<Guid> SkillIds { get; set; } = new List<Guid>();

    }
}
