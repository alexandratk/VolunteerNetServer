using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class UserSkillProfileModel : BaseModel
    {
        public Guid SkillId { get; set; }
        public SkillModel Skill { get; set; }
    }
}
