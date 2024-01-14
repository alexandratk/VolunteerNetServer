using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.DefaultData;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class SkillService : ISkillService
    {
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        public SkillService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<ValidationResult>> AddAsync(SkillCreationModel model)
        {
            var validationResults = new List<ValidationResult>();
            if (model == null)
            {
                validationResults.Add(new ValidationResult("invalidData"));
                return validationResults;
            }

            Skill newSkill = new Skill();
            newSkill.Id = Guid.NewGuid();
            newSkill.Title = newSkill.Id.ToString();

            await unitOfWork.SkillRepository.AddAsync(newSkill);

            List<SkillTranslation> newSkillTranslations = new List<SkillTranslation>();

            SkillTranslation newSkillTranslationEn = new SkillTranslation();
            newSkillTranslationEn.Id = Guid.NewGuid();
            newSkillTranslationEn.Language = Languages.LanguagesEnum.en.ToString();
            newSkillTranslationEn.Name = model.NameEn;
            newSkillTranslationEn.SkillId = newSkill.Id;

            SkillTranslation newSkillTranslationUk = new SkillTranslation();
            newSkillTranslationUk.Id = Guid.NewGuid();
            newSkillTranslationUk.Language = Languages.LanguagesEnum.uk.ToString();
            newSkillTranslationUk.Name = model.NameUk;
            newSkillTranslationUk.SkillId = newSkill.Id;

            SkillTranslation newSkillTranslationPl = new SkillTranslation();
            newSkillTranslationPl.Id = Guid.NewGuid();
            newSkillTranslationPl.Language = Languages.LanguagesEnum.pl.ToString();
            newSkillTranslationPl.Name = model.NamePl;
            newSkillTranslationPl.SkillId = newSkill.Id;

            newSkillTranslations.Add(newSkillTranslationEn);
            newSkillTranslations.Add(newSkillTranslationUk);
            newSkillTranslations.Add(newSkillTranslationPl);

            await unitOfWork.SkillRepository
                .AddRangeSkillTranslationsAsync(newSkillTranslations);
            return validationResults;
        }

        public async Task DeleteAsync(Guid modelId)
        {
            var unmapperSkill = await unitOfWork.SkillRepository.GetByIdAsync(modelId);
            if (unmapperSkill != null)
            {
                await unitOfWork.SkillRepository.DeleteAsync(unmapperSkill);
            }
        }

        public async Task<IEnumerable<SkillModel>> GetAllAsync(string language)
        {
            var unmapperSkills = await unitOfWork.SkillRepository.GetAllAsync();
            var mapperSkills = mapper.Map<IEnumerable<Skill>, IEnumerable<SkillModel>>(unmapperSkills);
            foreach (SkillModel skill in mapperSkills)
            {
                SkillTranslation? skillTranslation = await unitOfWork.SkillRepository
                    .GetSkillTranslationById(skill.Id, language);
                if (skillTranslation != null)
                {
                    skill.Title = skillTranslation.Name;
                }
            }
            mapperSkills = mapperSkills.OrderBy(x => x.Title);
            return mapperSkills;
        }

        public async Task<List<SkillModel>> GetListByUserIdAsync(Guid userId, string language)
        {
            var unmapperSkills = await unitOfWork.SkillRepository.GetAllAsync();
            var mapperSkills = mapper.Map<List<Skill>, List<SkillModel>>(unmapperSkills);

            var unmapperUserSkills = await unitOfWork.UserSkillRepository.GetListUserSkillByUserId(userId);
            var mapperUserSkills = mapper.Map<List<UserSkill>, List<UserSkillModel>>(unmapperUserSkills);

            foreach (UserSkillModel userSkill in mapperUserSkills)
            {
                int i = 0;
                while (i < mapperSkills.Count && mapperSkills[i].Id != userSkill.Skill.Id)
                {
                    i++;
                }
                if (i < mapperSkills.Count)
                {
                    mapperSkills.RemoveAt(i);
                }
            }

            foreach (SkillModel skill in mapperSkills)
            {
                SkillTranslation? skillTranslation = await unitOfWork.SkillRepository
                    .GetSkillTranslationById(skill.Id, language);
                if (skillTranslation != null)
                {
                    skill.Title = skillTranslation.Name;
                }
            }
            mapperSkills = mapperSkills.OrderBy(x => x.Title).ToList();
            return mapperSkills;
        }

        public async Task<SkillModel> GetByIdAsync(Guid id)
        {
            var unmapperSkill = await unitOfWork.SkillRepository.GetByIdAsync(id);
            var mapperUser = mapper.Map<Skill, SkillModel>(unmapperSkill);
            return mapperUser;
        }

        public async Task UpdateAsync(SkillModel model)
        {
            var mapperSkill = mapper.Map<SkillModel, Skill>(model);
            await unitOfWork.SkillRepository.UpdateAsync(mapperSkill);
        }

        public Task<IEnumerable<SkillModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
