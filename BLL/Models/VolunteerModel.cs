using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class VolunteerModel : BaseModel
    {
        public UserModel User { get; set; }
        public Guid UserId { get; set; }

        public ApplicationModel Application { get; set; }
        public Guid ApplicationId { get; set; }

        public int Status { get; set; }
    }
}
