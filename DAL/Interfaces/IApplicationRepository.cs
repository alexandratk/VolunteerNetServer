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

        Task<Application?> GetByIdWithVolunteersAsync(Guid id);

        Task<Application?> GetByIdWithoutForeignAsync(Guid id);

        ApplicationDocument? GetDocumentById(Guid id);

        Task<List<Application>> GetListForAutoPayment(List<Guid> categoryIds);

        Task<List<Application>> GetListForProcessingAsync();

        Task<List<Application>> GetListForUserAsync(Guid userId);

        Task<List<Application>> GetListWithCurrentData();

        Task UpdateRange(List<Application> entities);
    }
}
