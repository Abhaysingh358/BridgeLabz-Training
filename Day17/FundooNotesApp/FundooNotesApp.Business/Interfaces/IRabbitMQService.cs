using FundooNotesApp.Models.Entities;
using System.Threading.Tasks;

namespace FundooNotesApp.Business.Interfaces
{
    public interface IRabbitMQService
    {
        Task PublishReminderAsync(ReminderMessage reminderMessage);
    }
}
