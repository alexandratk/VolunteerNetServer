using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User : BaseEntity
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Guid CityId { get; set; }
        public City City { get; set; }

        public string Phone { get; set; }

        public string Role { get; set; }

        public ProfilePicture? ProfilePicture { get; set; }

        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<UserSkill> UserSkills { get; set; } = new List<UserSkill>();

        public List<Application> Applications { get; set; } = new List<Application>();

        public List<Application> RecievedApplications { get; set; } = new List<Application>();
        public List<Volunteer> Volunteers { get; set; } = new List<Volunteer>();
    }
}
