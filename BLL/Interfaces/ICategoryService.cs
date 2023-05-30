using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICategoryService : IService<CategoryModel>
    {
        Task<List<ValidationResult>> AddAsync(CategoryCreationModel model);

        Task<IEnumerable<CategoryModel>> GetAllAsync(string language);
    }
}
