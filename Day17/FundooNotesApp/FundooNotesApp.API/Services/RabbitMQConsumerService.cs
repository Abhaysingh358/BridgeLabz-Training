using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using FundooNotesApp.Repository.Context;
using FundooNotesApp.Models.Entities;
using FundooNotesApp.Business.Interfaces;

namespace FundooNotesApp.API.Services
{
    public class RabbitMQConsumerService : BackgroundService
    {
        private readonly IConfiguration _configuration;
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly ILogger<RabbitMQConsumerService> _logger;
        private IConnection? _connection;
        private IChannel? _channel;

        public RabbitMQConsumerService(
            IConfiguration configuration,
            IServiceScopeFactory scopeFactory,
            ILogger<RabbitMQConsumerService> logger)
        {
            _configuration = configuration;
            _scopeFactory = scopeFactory;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("RabbitMQ Consumer Service is starting.");

            var rabbitConfig = _configuration.GetSection("RabbitMQ");
            var factory = new ConnectionFactory
            {
                HostName = rabbitConfig["HostName"] ?? "localhost",
                Port = int.Parse(rabbitConfig["Port"] ?? "5672"),
                UserName = rabbitConfig["UserName"] ?? "guest",
                Password = rabbitConfig["Password"] ?? "guest"
            };

            var queueName = rabbitConfig["QueueName"] ?? "fundoo_reminder_queue";

            try
            {
                _connection = await factory.CreateConnectionAsync(stoppingToken);
                _channel = await _connection.CreateChannelAsync(cancellationToken: stoppingToken);

                await _channel.QueueDeclareAsync(
                    queue: queueName,
                    durable: true,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null,
                    cancellationToken: stoppingToken
                );

                var consumer = new AsyncEventingBasicConsumer(_channel);
                consumer.ReceivedAsync += async (sender, @event) =>
                {
                    try
                    {
                        var body = @event.Body.ToArray();
                        var json = Encoding.UTF8.GetString(body);
                        var payload = JsonSerializer.Deserialize<ReminderMessage>(json);

                        if (payload != null)
                        {
                            _logger.LogInformation("Received reminder message for user {Email}", payload.UserEmail);

                            using var scope = _scopeFactory.CreateScope();
                            
                            // Resolve and use Business layer SMTP service
                            var smtpService = scope.ServiceProvider.GetRequiredService<ISmtpService>();
                            var subject = $"Fundoo Notes Reminder: {payload.NoteTitle}";
                            var emailBody = $"Hi {payload.UserFirstName},\n\nThis is a scheduled reminder for your note:\n\nTitle: {payload.NoteTitle}\nDescription: {payload.NoteDescription}\nScheduled Time: {payload.ReminderTime}\n\nBest regards,\nFundoo Notes Team";
                            
                            try
                            {
                                await smtpService.SendEmailAsync(payload.UserEmail, subject, emailBody);
                            }
                            catch (Exception emailEx)
                            {
                                _logger.LogError(emailEx, "Failed to send email to {Email} via ISmtpService.", payload.UserEmail);
                            }

                            // Save notification log and update reminder status
                            try
                            {
                                var context = scope.ServiceProvider.GetRequiredService<UserContext>();
                                
                                var notification = new Notification
                                {
                                    UserId = payload.UserId,
                                    NoteId = payload.NoteId,
                                    ReminderId = payload.ReminderId,
                                    Title = subject,
                                    Message = $"Reminder triggered: {payload.NoteDescription}",
                                    IsRead = false,
                                    CreatedAt = DateTime.UtcNow
                                };
                                context.Notifications.Add(notification);

                                var reminder = await context.Reminders.FindAsync(payload.ReminderId);
                                if (reminder != null)
                                {
                                    reminder.IsNotified = true;
                                    reminder.IsCompleted = true;
                                    reminder.UpdatedAt = DateTime.UtcNow;
                                }

                                await context.SaveChangesAsync();
                                _logger.LogInformation("Saved notification log and marked reminder {ReminderId} as completed in database.", payload.ReminderId);
                            }
                            catch (Exception dbEx)
                            {
                                _logger.LogError(dbEx, "Failed to update reminder/save notification record in DB for reminder ID {ReminderId}.", payload.ReminderId);
                            }
                        }

                        // Acknowledge message
                        await _channel.BasicAckAsync(deliveryTag: @event.DeliveryTag, multiple: false);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Error processing consumed reminder message.");
                        await _channel.BasicNackAsync(deliveryTag: @event.DeliveryTag, multiple: false, requeue: false);
                    }
                };

                await _channel.BasicConsumeAsync(
                    queue: queueName,
                    autoAck: false,
                    consumer: consumer,
                    cancellationToken: stoppingToken
                );

                _logger.LogInformation("RabbitMQ Consumer Service is listening on queue '{Queue}'.", queueName);

                // Keep service alive
                await Task.Delay(Timeout.Infinite, stoppingToken);
            }
            catch (OperationCanceledException)
            {
                _logger.LogInformation("RabbitMQ Consumer Service cancellation requested.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fatal error occurred in RabbitMQ Consumer Service.");
            }
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("RabbitMQ Consumer Service is stopping.");

            if (_channel != null)
            {
                await _channel.CloseAsync(cancellationToken);
            }

            if (_connection != null)
            {
                await _connection.CloseAsync(cancellationToken);
            }

            await base.StopAsync(cancellationToken);
        }
    }
}
