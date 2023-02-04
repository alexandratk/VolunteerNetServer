using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class AuthResponseModel
    {
        public string Role { get; set; }
        public string jwtToken { get; set; }

        public AuthResponseModel(Guid id, string role, string jwtToken)
        {
            Role = role;
            this.jwtToken = jwtToken;
        }

        public AuthResponseModel()
        {
            Role = "";
            jwtToken = "";
        }
    }
}
