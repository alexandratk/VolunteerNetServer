using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ISkillRepository : IRepository<Skill>
    {
        Task AddRangeSkillTranslationsAsync(List<SkillTranslation> entities);

        Task<SkillTranslation?> GetSkillTranslationById(Guid id, string language);
    }
}
