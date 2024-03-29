﻿using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IApplicationService : IService<ApplicationModel>
    {
        Task<List<ValidationResult>> AddAsync(Guid userId, ApplicationCreationModel model);

        Task<List<ValidationResult>> ApproveApplication(Guid applicationId, Guid moderatorId);

        Task<List<ValidationResult>> CompleteApplication(Guid applicationId, Guid moderatorId);

        Task CompleteApplicationBackgroundService();

        Task DeleteAsync(Guid modelId, Guid userId, string userRole);

        Task<List<ApplicationViewModel>> GetAllAsync(string userRole, string language);

        Task<IEnumerable<ApplicationViewModel>> GetListForProcessingAsync(string language);

        Task<IEnumerable<ApplicationViewModel>> GetListForUserAsync(Guid userId, string language);

        Task<List<ValidationResult>> ForbidApplication(NotificationCreationModel value, Guid moderatorId);

        int test();
    }
}
