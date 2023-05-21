using DAL.Data;
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
    public class NotificationRepository : INotificationRepository
    {
        VolunteerNetServerDBContext _context;

        public NotificationRepository(VolunteerNetServerDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Notification entity)
        {
            _context.Notifications.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Notification entity)
        {
            _context.Notifications.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Notification>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Notification?> GetByIdAsync(Guid id)
        {
            Notification? notification = _context.Notifications
                .Where(x => x.Id == id).AsNoTracking().FirstOrDefault();
            return Task.FromResult(notification);
        }

        public async Task<List<Notification>> GetListByUserRecipientId(Guid receiptUserId)
        {
            List<Notification> notifications = await _context.Notifications
                .Where(x => x.UserRecipientId== receiptUserId)
                .Include("UserRecipient").Include("UserSender").Include("Application").AsNoTracking().ToListAsync();
            return notifications;
        }

        public Task Update(Notification entity)
        {
            throw new NotImplementedException();
        }
    }
}
