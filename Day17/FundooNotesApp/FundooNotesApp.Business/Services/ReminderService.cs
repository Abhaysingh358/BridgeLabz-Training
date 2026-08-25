using FundooNotesApp.Business.Interfaces;
using FundooNotesApp.Models.DTOs.Request;
using FundooNotesApp.Models.Entities;
using FundooNotesApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundooNotesApp.Business.Services
{
    public class ReminderService : IReminderService
    {
        private readonly IReminderRepository _reminderRepository;

        public ReminderService(IReminderRepository reminderRepository)
        {
            _reminderRepository = reminderRepository;
        }

        public async Task<ReminderModel> CreateReminderAsync(CreateReminderDto dto, int userId)
        {
            var reminder = new Reminder
            {
                NoteId = dto.NoteId,
                UserId = userId,
                ReminderTime = dto.ReminderTime,
                IsCompleted = false,
                IsCancelled = false,
                IsNotified = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            var result = await _reminderRepository.CreateReminderAsync(reminder);
            return MapToModel(result);
        }

        public async Task<ReminderModel?> GetReminderByIdAsync(int reminderId, int userId)
        {
            var reminder = await _reminderRepository.GetReminderByIdAsync(reminderId, userId);
            return reminder != null ? MapToModel(reminder) : null;
        }

        public async Task<IEnumerable<ReminderModel>> GetAllRemindersAsync(int userId)
        {
            var reminders = await _reminderRepository.GetRemindersAsync(userId);
            return reminders.Select(MapToModel);
        }

        public async Task<bool> DeleteReminderAsync(int reminderId, int userId)
        {
            return await _reminderRepository.DeleteReminderAsync(reminderId, userId);
        }

        private ReminderModel MapToModel(Reminder r)
        {
            return new ReminderModel
            {
                ReminderId = r.ReminderId,
                NoteId = r.NoteId,
                UserId = r.UserId,
                ReminderTime = r.ReminderTime,
                IsCompleted = r.IsCompleted,
                IsCancelled = r.IsCancelled,
                IsNotified = r.IsNotified,
                CreatedAt = r.CreatedAt,
                UpdatedAt = r.UpdatedAt
            };
        }
    }
}
