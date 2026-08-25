using FundooNotesApp.Models.DTOs.Request;
using FundooNotesApp.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FundooNotesApp.Business.Interfaces
{
    public interface IReminderService
    {
        Task<ReminderModel> CreateReminderAsync(CreateReminderDto dto, int userId);
        Task<ReminderModel?> GetReminderByIdAsync(int reminderId, int userId);
        Task<IEnumerable<ReminderModel>> GetAllRemindersAsync(int userId);
        Task<bool> DeleteReminderAsync(int reminderId, int userId);
    }
}
