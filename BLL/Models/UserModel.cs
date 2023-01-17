using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class UserModel : BaseModel
    {
        public string Login { get; set; }

        public string Password { get; set; }
    }
}
