﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Skill : BaseEntity
    {
        public string Title { get; set; }

        public List<User> Users { get; set; } = new List<User>();
        public List<UserSkill> UserSkills { get; set; } = new List<UserSkill>();

        public List<Application> Applications { get; set; } = new List<Application>();
        public List<ApplicationSkill> ApplicationSkills { get; set; } = new List<ApplicationSkill>();

        public List<SkillTranslation> SkillTranslations { get; set; }
    }
}
