using FundooNotesApp.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FundooNotesApp.Repository.Interfaces
{
    public interface IReminderRepository
    {
        Task<Reminder> CreateReminderAsync(Reminder reminder);
        Task<Reminder?> GetReminderByIdAsync(int reminderId, int userId);
        Task<IEnumerable<Reminder>> GetRemindersAsync(int userId);
        Task<bool> DeleteReminderAsync(int reminderId, int userId);
    }
}