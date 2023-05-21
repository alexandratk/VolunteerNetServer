using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Application : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        
        public int Status { get; set; }

        public string Type { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Kind { get; set; }

        public int? RequiredNumberOfVolunteers { get; set; }

        public int? NumberOfVolunteers { get; set; }

        public decimal? RequiredSum { get; set; }

        public decimal? CurrentSum { get; set; }

        public string? CardNumber { get; set; }

        public string? AccountNumber { get; set; }

        public string? OwnerCardName { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Guid CityId { get; set; }
        public City City { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public List<ApplicationSkill> ApplicationSkills { get; set; } = new List<ApplicationSkill>();
        public List<Skill> Skills { get; set; } = new List<Skill>();

        public List<User> Users { get; set; } = new List<User>();
        public List<Volunteer> Volunteers { get; set; } = new List<Volunteer>();

        public List<Notification> Notifications { get; set; } = new List<Notification>();
    }
}
