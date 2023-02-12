using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ProfilePictureModel : BaseModel
    {
        public string Format { get; set; }

        public byte[] Data { get; set; }

        public Guid UserId { get; set; }

        public UserModel User { get; set; }
    }
}
