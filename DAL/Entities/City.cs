﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class City : BaseEntity
    {
        public string ISO { get; set; }

        public Guid CountryId { get; set; }
        public Country Country { get; set; }

        public List<User> Users { get; set; }

        public List<CityTranslation> CityTranslations { get; set; }
    }
}
