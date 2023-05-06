using DAL.Data;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        VolunteerNetServerDBContext _context;

        public CategoryRepository(VolunteerNetServerDBContext context)
        {
            _context = context;
        }

        public Task<CategoryTranslation?> GetCategoryTranslationById(Guid id, string language)
        {
            CategoryTranslation? categoryTranslation = _context.CategoryTranslations.AsNoTracking()
                .Where(r => r.CategoryId == id && r.Language == language).FirstOrDefault();
            return Task.FromResult(categoryTranslation);
        }

        public Task AddAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Category>> GetAllAsync()
        {
            List<Category> categories = await _context.Categories.AsNoTracking().ToListAsync();
            return categories;
        }

        public Task<Category?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
