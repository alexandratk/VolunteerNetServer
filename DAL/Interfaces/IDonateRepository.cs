using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IDonateRepository : IRepository<Donate>
    {
        Task AddRangeAsync(List<Donate> entities);

        Task<List<Donate>> GetListByApplicationId(Guid applicationId);

        Task<List<Donate>> GetListDonatesWithTerm(int numberOfDays);

        Task<List<Donate>> GetListDonatesWithoutTerm();
    }
}
