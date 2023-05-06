using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DefaultData
{
    public class Categories
    {
        const int NumberOfCategories = 5;
        public List<Category> CategoriesList { get; set; } = new List<Category>();
        public List<CategoryTranslation> CategoryTranslations { get; set; } = new List<CategoryTranslation>();

        public Categories()
        {
            List<Guid> categoryIds = new List<Guid>();
            for (int i = 0; i < NumberOfCategories; i++)
            {
                categoryIds.Add(Guid.NewGuid());
            }

            CategoriesList.AddRange(
                new Category[]
                {
                    new Category() { Id = categoryIds[0], Title = "health care" },
                    new Category() { Id = categoryIds[1], Title = "education" },
                    new Category() { Id = categoryIds[2], Title = "sports and physical culture" },
                    new Category() { Id = categoryIds[3], Title = "culture and art" },
                    new Category() { Id = categoryIds[4], Title = "social programs" }
                });

            CategoryTranslations.AddRange(
                new CategoryTranslation[]
                {
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[0], Name = "health care", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[0], Name = "охорона здоров'я", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[1], Name = "education", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[1], Name = "освіта", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[2], Name = "sport and physical culture", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[2], Name = "спорт та фізична культура", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[3], Name = "culture and art", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[3], Name = "культура та мистецтво", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[4], Name = "social programs", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[4], Name = "соціальні програми", DescriptionCategory = " " },
                });
        }
    }
}
