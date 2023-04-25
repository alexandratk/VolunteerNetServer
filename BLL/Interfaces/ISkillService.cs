using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ISkillService : IService<SkillModel>
    {
        Task<SkillModel> GetByIdAsync(Guid id);

        Task AddAsync(SkillModel model);

        Task<IEnumerable<SkillModel>> GetAllAsync(string language);

        Task<List<SkillModel>> GetListByUserIdAsync(Guid userId, string language);
    }
}
