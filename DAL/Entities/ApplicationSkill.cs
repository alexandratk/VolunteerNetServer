using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ApplicationSkill : BaseEntity
    {
        public Guid ApplicationId { get; set; }
        public Application Application { get; set; }

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
