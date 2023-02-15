using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class UserSkill
    {
        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public string DocumentFormat { get; set; }
        public byte[] Document { get; set; }
    }
}
