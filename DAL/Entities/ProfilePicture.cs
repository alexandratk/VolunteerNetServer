using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProfilePicture : BaseEntity
    {
        public string Format { get; set; }

        public byte[] Data { get; set; }

        public Guid UserId { get; set; }
        
        public User User { get; set; }
    }
}
