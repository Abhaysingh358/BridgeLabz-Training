using FundooNotesApp.Models.Entities;
using FundooNotesApp.Repository.Context;
using FundooNotesApp.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundooNotesApp.Repository.Implementations
{
    public class ReminderRepository : IReminderRepository
    {
        private readonly UserContext _context;

        public ReminderRepository(UserContext context)
        {
            _context = context;
        }

        public async Task<Reminder> CreateReminderAsync(Reminder reminder)
        {
            _context.Reminders.Add(reminder);
            await _context.SaveChangesAsync();
            return reminder;
        }

        public async Task<Reminder?> GetReminderByIdAsync(int reminderId, int userId)
        {
            return await _context.Reminders
                .FirstOrDefaultAsync(r => r.ReminderId == reminderId && r.UserId == userId);
        }

        public async Task<IEnumerable<Reminder>> GetRemindersAsync(int userId)
        {
            return await _context.Reminders
                .Where(r => r.UserId == userId)
                .ToListAsync();
        }

        public async Task<bool> DeleteReminderAsync(int reminderId, int userId)
        {
            var reminder = await _context.Reminders
                .FirstOrDefaultAsync(r => r.ReminderId == reminderId && r.UserId == userId);

            if (reminder == null)
            {
                return false;
            }

            _context.Reminders.Remove(reminder);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}