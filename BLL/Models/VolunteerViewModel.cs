using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class VolunteerViewModel : BaseModel
    {
        public Guid UserId { get; set; }

        public UserViewModel User { get; set; }

        public Guid ApplicationId { get; set; }

        public ApplicationViewModel Application { get; set; }

        public string Status { get; set; }

        public int StatusNumber { get; set; }
    }
}
