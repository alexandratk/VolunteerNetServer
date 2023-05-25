using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ApplicationPicture : BaseEntity
    {
        public string Format { get; set; }

        public byte[] Data { get; set; }

        public Guid ApplicationId { get; set; }

        public Application Application { get; set; }
    }
}
