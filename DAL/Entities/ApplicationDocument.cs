using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ApplicationDocument : BaseEntity
    {
        public string Title { get; set; }
        public string DocumentFormat { get; set; }
        public byte[] Document { get; set; }

        public Guid ApplicationId { get; set; }
        public Application Application { get; set; }
    }
}
