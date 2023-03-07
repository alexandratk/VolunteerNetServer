using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
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

        public async Task AddAsync(SkillModel model)
        {
            model.Id = Guid.NewGuid();
            var mapperUser = mapper.Map<SkillModel, Skill>(model);
            await unitOfWork.SkillRepository.AddAsync(mapperUser);
        }

        public async Task DeleteAsync(Guid modelId)
        {
            var unmapperSkill = await unitOfWork.SkillRepository.GetByIdAsync(modelId);
            if (unmapperSkill != null)
            {
                await unitOfWork.SkillRepository.DeleteAsync(unmapperSkill);
            }
        }

        public async Task<IEnumerable<SkillModel>> GetAllAsync()
        {
            var unmapperSkills = await unitOfWork.SkillRepository.GetAllAsync();
            var mapperSkills = mapper.Map<IEnumerable<Skill>, IEnumerable<SkillModel>>(unmapperSkills);
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
            await unitOfWork.SkillRepository.Update(mapperSkill);
        }
    }
}
