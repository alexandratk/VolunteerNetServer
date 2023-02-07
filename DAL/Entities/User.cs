﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User : BaseEntity
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public byte[] Image { get; set; }

        public ProfilePicture ProfilePicture { get; set; }
    }
}
