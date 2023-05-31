using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ISkillService : IService<SkillModel>
    {
        Task<SkillModel> GetByIdAsync(Guid id);

        Task<List<ValidationResult>> AddAsync(SkillCreationModel model);

        Task<IEnumerable<SkillModel>> GetAllAsync(string language);

        Task<List<SkillModel>> GetListByUserIdAsync(Guid userId, string language);
    }
}
