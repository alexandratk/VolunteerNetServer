using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class UserSkillModel : BaseModel
    {
        public Guid SkillId { get; set; }
        public SkillModel Skill { get; set; }

        public Guid UserId { get; set; }
        public UserModel User { get; set; }

        public string DocumentFormat { get; set; }
        public byte[] Document { get; set; }
    }
}
