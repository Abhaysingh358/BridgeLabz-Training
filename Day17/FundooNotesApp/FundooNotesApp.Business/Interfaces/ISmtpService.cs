using System.Threading.Tasks;

namespace FundooNotesApp.Business.Interfaces
{
    public interface ISmtpService
    {
        Task SendEmailAsync(string toEmail, string subject, string body);
    }
}
