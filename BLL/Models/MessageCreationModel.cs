﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class MessageCreationModel : BaseModel
    {
        public string User { get; set; }

        public string Text { get; set; }

        public Guid ApplicationId { get; set; }
    }
}
