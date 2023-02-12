using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class UserViewModel : BaseModel
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public string ProfilePicture { get; set; }

        public string ProfilePictureFormat { get; set; }
    }
}
