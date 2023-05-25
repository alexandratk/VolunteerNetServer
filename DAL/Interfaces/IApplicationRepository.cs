using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IApplicationRepository : IRepository<Application>
    {
        Task AddDocumentAsync(ApplicationDocument entity);

        ApplicationDocument? GetDocumentById(Guid id);

        Task<List<Application>> GetListForProcessingAsync();

        Task<List<Application>> GetListForUserAsync(Guid userId);
    }
}
