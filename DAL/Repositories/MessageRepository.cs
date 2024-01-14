﻿using DAL.Data;
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
    public class MessageRepository : IMessageRepository
    {
        VolunteerNetServerDBContext _context;

        public MessageRepository(VolunteerNetServerDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Message entity)
        {
            _context.Messages.Add(entity);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(Message entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Message>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Message?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Message>> GetListByApplicationIdAsync(Guid applicationId)
        {
            List<Message> messages = await _context.Messages
                .Include("Volunteer").Include("Volunteer.User").Include("Volunteer.User.ProfilePicture")
                .Where(x => x.VolunteerApplicationId == applicationId).OrderBy(x => x.DateTime).AsNoTracking().ToListAsync();
            return messages;
        }

        public Task UpdateAsync(Message entity)
        {
            throw new NotImplementedException();
        }
    }
}
