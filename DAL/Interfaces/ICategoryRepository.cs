using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task AddRangeCategoryTranslationsAsync(List<CategoryTranslation> entities);

        Task<CategoryTranslation?> GetCategoryTranslationById(Guid id, string language);
    }
}
