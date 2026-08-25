using FundooNotesApp.Business.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FundooNotesApp.Business.Services
{
    public class SmtpService : ISmtpService
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<SmtpService> _logger;

        public SmtpService(IConfiguration configuration, ILogger<SmtpService> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            var smtpConfig = _configuration.GetSection("Smtp");
            var host = smtpConfig["Host"];
            var port = int.Parse(smtpConfig["Port"] ?? "587");
            var enableSsl = bool.Parse(smtpConfig["EnableSsl"] ?? "true");
            var username = smtpConfig["Username"];
            var password = smtpConfig["Password"];
            var fromAddress = smtpConfig["FromAddress"] ?? "no-reply@fundoonotes.com";

            if (string.IsNullOrEmpty(host) || 
                (host == "smtp.gmail.com" && (string.IsNullOrEmpty(username) || username.Contains("your_email@gmail.com"))))
            {
                _logger.LogWarning("SMTP is not configured with real credentials. Skipping email delivery to {Email}.", toEmail);
                return;
            }

            _logger.LogInformation("Sending email to {Email} via SMTP host {Host}", toEmail, host);

            using var mailMessage = new MailMessage
            {
                From = new MailAddress(fromAddress),
                Subject = subject,
                Body = body,
                IsBodyHtml = false
            };
            mailMessage.To.Add(toEmail);

            using var smtpClient = new SmtpClient(host, port)
            {
                Credentials = new NetworkCredential(username, password),
                EnableSsl = enableSsl
            };

            await smtpClient.SendMailAsync(mailMessage);
            _logger.LogInformation("Email sent successfully to {Email}.", toEmail);
        }
    }
}
