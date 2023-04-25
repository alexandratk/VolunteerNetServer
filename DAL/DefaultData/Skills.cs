using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DefaultData
{
    public class Skills
    {
        const int NumberOfSkills = 4;
        public List<Skill> SkillsList { get; set; } = new List<Skill>();
        public List<SkillTranslation> SkillTranslations { get; set; } = new List<SkillTranslation>();

        public Skills() 
        {
            List<Guid> skillIds = new List<Guid>();
            for (int i = 0; i < NumberOfSkills; i++)
            {
                skillIds.Add(Guid.NewGuid());
            }

            SkillsList.AddRange(
                new Skill[]
                {
                    new Skill() { Id = skillIds[0], Title = "medicine" },
                    new Skill() { Id = skillIds[1], Title = "cooking" },
                    new Skill() { Id = skillIds[2], Title = "building" },
                    new Skill() { Id = skillIds[3], Title = "psychology" }
                });

            SkillTranslations.AddRange(
                new SkillTranslation[]
                {
                    new SkillTranslation() { Id = Guid.NewGuid(), Language = "en", SkillId = skillIds[0], Name = "medicine" },
                    new SkillTranslation() { Id = Guid.NewGuid(), Language = "uk", SkillId = skillIds[0], Name = "медицина" },
                    new SkillTranslation() { Id = Guid.NewGuid(), Language = "en", SkillId = skillIds[1], Name = "cooking" },
                    new SkillTranslation() { Id = Guid.NewGuid(), Language = "uk", SkillId = skillIds[1], Name = "кулінарія" },
                    new SkillTranslation() { Id = Guid.NewGuid(), Language = "en", SkillId = skillIds[2], Name = "building" },
                    new SkillTranslation() { Id = Guid.NewGuid(), Language = "uk", SkillId = skillIds[2], Name = "будівництво" },
                    new SkillTranslation() { Id = Guid.NewGuid(), Language = "en", SkillId = skillIds[3], Name = "psychology" },
                    new SkillTranslation() { Id = Guid.NewGuid(), Language = "uk", SkillId = skillIds[3], Name = "психологія" },
                });
        }
    }
}
