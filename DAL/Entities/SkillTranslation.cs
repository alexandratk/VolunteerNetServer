using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class SkillTranslation : BaseEntity
    {
        public string Language { get; set; }

        public string Name { get; set; }

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
