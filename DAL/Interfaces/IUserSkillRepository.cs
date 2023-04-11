using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserSkillRepository : IRepository<UserSkill>
    {
        UserSkill? GetById(Guid id);
        
        Task<UserSkill?> GetByUserIdSkillIdAsync(Guid userId, Guid skillId);
        
        Task<List<UserSkill>> GetListUserSkillByUserId(Guid userId);
    }
}
