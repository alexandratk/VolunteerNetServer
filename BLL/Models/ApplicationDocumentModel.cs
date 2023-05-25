using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ApplicationDocumentModel : BaseModel
    {
        public string Title { get; set; }
        public string DocumentFormat { get; set; }
        public byte[] Document { get; set; }

        public Guid ApplicationId { get; set; }
        public ApplicationModel Application { get; set; }
    }
}
