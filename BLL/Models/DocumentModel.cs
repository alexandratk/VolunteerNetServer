using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class DocumentModel
    {
        public byte[] Document { get; set; }

        public string DocumentFormat { get; set; }

        public string? Title { get; set; }
    }
}
