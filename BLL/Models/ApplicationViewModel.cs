﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ApplicationViewModel : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public int StatusNumber { get; set; }

        public string Status { get; set; }

        public Guid UserId { get; set; }
    }
}