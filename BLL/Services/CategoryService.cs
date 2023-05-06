using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CategoryService : ICategoryService
    {
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        private const string RoleUser = "user";

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public Task DeleteAsync(Guid modelId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoryModel>> GetAllAsync(string language)
        {
            var unmapperCategories = await unitOfWork.CategoryRepository.GetAllAsync();
            var mapperCategories = mapper.Map<IEnumerable<Category>, IEnumerable<CategoryModel>>(unmapperCategories);
            foreach (CategoryModel category in mapperCategories)
            {
                CategoryTranslation? categoryTranslation = await unitOfWork.CategoryRepository
                    .GetCategoryTranslationById(category.Id, language);
                if (categoryTranslation != null)
                {
                    category.Title = categoryTranslation.Name;
                    category.DescriptionCategory = categoryTranslation.DescriptionCategory;
                }
            }
            return mapperCategories;
        }

        public Task<IEnumerable<CategoryModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CategoryModel model)
        {
            throw new NotImplementedException();
        }
    }
}
