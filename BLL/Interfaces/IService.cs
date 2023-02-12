using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IService<TModel> where TModel : BaseModel
    {
        Task<IEnumerable<TModel>> GetAllAsync();

        Task UpdateAsync(TModel model);

        Task DeleteAsync(Guid modelId);

    }
}
