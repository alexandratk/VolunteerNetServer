using AutoMapper;
using BLL.Helpers;
using BLL.Interfaces;
using BLL.Models;
using DAL.DefaultData;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public async Task<List<ValidationResult>> AddAsync(CategoryCreationModel model)
        {
            var validationResults = new List<ValidationResult>();
            if (model == null)
            {
                validationResults.Add(new ValidationResult("invalidData"));
                return validationResults;
            }

            Category newCategory = new Category();
            newCategory.Id = Guid.NewGuid();
            newCategory.Title = newCategory.Id.ToString();

            await unitOfWork.CategoryRepository.AddAsync(newCategory);

            List<CategoryTranslation> newCategoryTranslations = new List<CategoryTranslation>();
            

            CategoryTranslation newCategoryTranslationEn = new CategoryTranslation();
            newCategoryTranslationEn.Id = Guid.NewGuid();
            newCategoryTranslationEn.Language = Languages.LanguagesEnum.en.ToString();
            newCategoryTranslationEn.Name = model.NameEn;
            newCategoryTranslationEn.DescriptionCategory = model.DescriptionCategoryEn;
            newCategoryTranslationEn.CategoryId = newCategory.Id;

            CategoryTranslation newCategoryTranslationUk = new CategoryTranslation();
            newCategoryTranslationUk.Id = Guid.NewGuid();
            newCategoryTranslationUk.Language = Languages.LanguagesEnum.uk.ToString();
            newCategoryTranslationUk.Name = model.NameUk;
            newCategoryTranslationUk.DescriptionCategory = model.DescriptionCategoryUk;
            newCategoryTranslationUk.CategoryId = newCategory.Id;

            CategoryTranslation newCategoryTranslationPl = new CategoryTranslation();
            newCategoryTranslationPl.Id = Guid.NewGuid();
            newCategoryTranslationPl.Language = Languages.LanguagesEnum.pl.ToString();
            newCategoryTranslationPl.Name = model.NamePl;
            newCategoryTranslationPl.DescriptionCategory = model.DescriptionCategoryPl;
            newCategoryTranslationPl.CategoryId = newCategory.Id;

            newCategoryTranslations.Add(newCategoryTranslationEn);
            newCategoryTranslations.Add(newCategoryTranslationUk);
            newCategoryTranslations.Add(newCategoryTranslationPl);

            await unitOfWork.CategoryRepository
                .AddRangeCategoryTranslationsAsync(newCategoryTranslations);
            return validationResults;
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
