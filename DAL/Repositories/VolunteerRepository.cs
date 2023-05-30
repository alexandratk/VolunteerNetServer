using DAL.Data;
using DAL.DefaultData;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class VolunteerRepository : IVolunteerRepository
    {
        VolunteerNetServerDBContext _context;

        public VolunteerRepository(VolunteerNetServerDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Volunteer entity)
        {
            _context.Volunteers.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Volunteer entity)
        {
            _context.Volunteers.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByApplicationId(Guid applicationId)
        {
            List<Volunteer> volunteers = await _context.Volunteers
                .Where(x => x.ApplicationId == applicationId).AsNoTracking().ToListAsync();
            _context.Volunteers.RemoveRange(volunteers);
            await _context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Volunteer>> GetAllAsync()
        {
            List<Volunteer> volunteers = await _context.Volunteers.Include("User").Include("Application").AsNoTracking().ToListAsync();
            return volunteers;
        }

        public Task<Volunteer?> GetByIdAsync(Guid id)
        {
            Volunteer? volunteer = _context.Volunteers
                .Where(r => r.Id == id).Include("User").Include("Application").AsNoTracking().FirstOrDefault();
            return Task.FromResult(volunteer);
        }

        public Task<Volunteer?> GetByIdWithoutForeignAsync(Guid id)
        {
            Volunteer? volunteer = _context.Volunteers
                .Where(r => r.Id == id).AsNoTracking().FirstOrDefault();
            return Task.FromResult(volunteer);
        }

        public Task<Volunteer?> GetByUserIdApplicationId(Guid userId, Guid applicationId)
        {
            Volunteer? volunteer = _context.Volunteers.AsNoTracking()
                .Include("User").Include("User.ProfilePicture").Include("Application")
                .Where(r => r.UserId == userId && r.ApplicationId == applicationId).FirstOrDefault();
            return Task.FromResult(volunteer);
        }

        public Task<Volunteer?> GetByUserIdApplicationIdWithoutForeign(Guid userId, Guid applicationId)
        {
            Volunteer? volunteer = _context.Volunteers.AsNoTracking()
                .Where(r => r.UserId == userId && r.ApplicationId == applicationId).FirstOrDefault();
            return Task.FromResult(volunteer);
        }

        public async Task<List<Volunteer>> GetListByUserId(Guid userId)
        {
            List<Volunteer> volunteers = await _context.Volunteers.Include("User").Include("Application")
                .Where(x => x.UserId == userId && x.Status == (int)VolunteerStatuses.Status.Accepted)
                .AsNoTracking().ToListAsync();
            return volunteers;
        }

        public async Task<List<Volunteer>> GetListVolunteersInChat(Guid applicationId)
        {
            List<Volunteer> volunteers = await _context.Volunteers.Include("User")
                .Where(x => x.ApplicationId == applicationId && (x.Status == (int)VolunteerStatuses.Status.Accepted
                || x.Status == (int)VolunteerStatuses.Status.Owner)).AsNoTracking().ToListAsync();
            return volunteers;
        }

        public async Task<List<Volunteer>> GetListVolunteersInChatWithoutForeign(Guid applicationId)
        {
            List<Volunteer> volunteers = await _context.Volunteers
                .Where(x => x.ApplicationId == applicationId && (x.Status == (int)VolunteerStatuses.Status.Accepted
                || x.Status == (int)VolunteerStatuses.Status.Owner)).AsNoTracking().ToListAsync();
            return volunteers;
        }

        public async Task<List<Volunteer>> GetListWithChatsByUserId(Guid userId)
        {
            List<Volunteer> volunteers = await _context.Volunteers.Include("User").Include("Application")
                .Where(x => x.UserId == userId && 
                (x.Application.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Volunteer] ||
                x.Application.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Mixed]) &&
                (x.Status == (int)VolunteerStatuses.Status.Accepted ||
                x.Status == (int)VolunteerStatuses.Status.Owner ||
                x.Status == (int)VolunteerStatuses.Status.Completed))
                .AsNoTracking().ToListAsync();
            return volunteers;
        }

        public async Task<List<Volunteer>> GetListInProcessingByOwnerId(Guid userId)
        {
            List<Volunteer> volunteers = await _context.Volunteers.Include("User").Include("Application")
                .Where(x => x.Application.UserId == userId && x.Status == (int)VolunteerStatuses.Status.Processing)
                .AsNoTracking().ToListAsync();
            return volunteers;
        }

        public async Task Update(Volunteer entity)
        {
            _context.Entry(entity).State = EntityState.Detached;
            _context.Update(entity);
            await _context.SaveChangesAsync();
            _context.Entry(entity).State = EntityState.Detached;
        }
    }
}
