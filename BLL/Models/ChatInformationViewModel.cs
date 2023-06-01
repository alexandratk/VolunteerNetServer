using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ChatInformationViewModel
    {
        public ApplicationViewModel Application { get; set; }

        public List<VolunteerViewModel> Volunteers { get; set; } = new List<VolunteerViewModel>();
    }
}
