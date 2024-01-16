using DAL.Entities;

namespace DAL.DefaultData
{
    public class Categories
    {
        const int NumberOfCategories = 14;
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
                    new Category() { Id = categoryIds[0], Title = "health" },
                    new Category() { Id = categoryIds[1], Title = "education" },
                    new Category() { Id = categoryIds[2], Title = "sports and physical culture" },
                    new Category() { Id = categoryIds[3], Title = "culture and art" },
                    new Category() { Id = categoryIds[4], Title = "social programs" },
                    new Category() { Id = categoryIds[5], Title = "ecology" },
                    new Category() { Id = categoryIds[6], Title = "legal affairs" },
                    new Category() { Id = categoryIds[7], Title = "emergency response" },
                    new Category() { Id = categoryIds[8], Title = "construction" },
                    new Category() { Id = categoryIds[9], Title = "transport" },
                    new Category() { Id = categoryIds[10], Title = "blood donation" },
                    new Category() { Id = categoryIds[11], Title = "psychology" },
                    new Category() { Id = categoryIds[12], Title = "international projects" },
                    new Category() { Id = categoryIds[13], Title = "animal welfare" }
                });

            CategoryTranslations.AddRange(
                new CategoryTranslation[]
                {
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[0], Name = "health care", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[0], Name = "охорона здоров'я", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "pl", CategoryId = categoryIds[0], Name = "opieka zdrowotna", DescriptionCategory = " " },

                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[1], Name = "education", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[1], Name = "освіта", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "pl", CategoryId = categoryIds[1], Name = "edukacja", DescriptionCategory = " " },

                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[2], Name = "sport and physical culture", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[2], Name = "спорт та фізична культура", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "pl", CategoryId = categoryIds[2], Name = "sport i kultura fizyczna", DescriptionCategory = " " },

                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[3], Name = "culture and art", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[3], Name = "культура та мистецтво", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "pl", CategoryId = categoryIds[3], Name = "kultura i sztuka", DescriptionCategory = " " },

                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[4], Name = "social programs", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[4], Name = "соціальні програми", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "pl", CategoryId = categoryIds[4], Name = "programy społeczne", DescriptionCategory = " " },

                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[5], Name = "ecology", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[5], Name = "екологія", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "pl", CategoryId = categoryIds[5], Name = "ekologia", DescriptionCategory = " " },

                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[6], Name = "legal affairs", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[6], Name = "юридичні питання", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "pl", CategoryId = categoryIds[6], Name = "sprawy prawne", DescriptionCategory = " " },

                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[7], Name = "emergency response", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[7], Name = "надзвичайні ситуації", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "pl", CategoryId = categoryIds[7], Name = "reagowanie kryzysowe", DescriptionCategory = " " },

                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[8], Name = "construction", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[8], Name = "будівництво", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "pl", CategoryId = categoryIds[8], Name = "konstrukcja", DescriptionCategory = " " },

                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[9], Name = "transport", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[9], Name = "транспорт", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "pl", CategoryId = categoryIds[9], Name = "transport", DescriptionCategory = " " },

                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[10], Name = "blood donation", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[10], Name = "донорство крові", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "pl", CategoryId = categoryIds[10], Name = "krwiodawstwo", DescriptionCategory = " " },

                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[11], Name = "psychology", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[11], Name = "психологія", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "pl", CategoryId = categoryIds[11], Name = "psychologia", DescriptionCategory = " " },

                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[12], Name = "international projects", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[12], Name = "міжнародні проекти", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "pl", CategoryId = categoryIds[12], Name = "projekty międzynarodowe", DescriptionCategory = " " },

                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "en", CategoryId = categoryIds[13], Name = "animal welfare", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "uk", CategoryId = categoryIds[13], Name = "захист тварин", DescriptionCategory = " " },
                    new CategoryTranslation() { Id = Guid.NewGuid(), Language = "pl", CategoryId = categoryIds[13], Name = "dobrostan zwierząt", DescriptionCategory = " " }
                });
        }
    }
}
