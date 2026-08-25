using FundooNotesApp.Business.Interfaces;
using FundooNotesApp.Models.Entities;
using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using System;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FundooNotesApp.Business.Services
{
    public class RabbitMQService : IRabbitMQService
    {
        private readonly ConnectionFactory _factory;
        private readonly string _queueName;

        public RabbitMQService(IConfiguration configuration)
        {
            var rabbitConfig = configuration.GetSection("RabbitMQ");
            
            _factory = new ConnectionFactory
            {
                HostName = rabbitConfig["HostName"] ?? "localhost",
                Port = int.Parse(rabbitConfig["Port"] ?? "5672"),
                UserName = rabbitConfig["UserName"] ?? "guest",
                Password = rabbitConfig["Password"] ?? "guest"
            };
            
            _queueName = rabbitConfig["QueueName"] ?? "fundoo_reminder_queue";
        }

        public async Task PublishReminderAsync(ReminderMessage reminderMessage)
        {
            using var connection = await _factory.CreateConnectionAsync();
            using var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(
                queue: _queueName,
                durable: true,
                exclusive: false,
                autoDelete: false,
                arguments: null
            );

            var json = JsonSerializer.Serialize(reminderMessage);
            var body = Encoding.UTF8.GetBytes(json);

            await channel.BasicPublishAsync(
                exchange: string.Empty,
                routingKey: _queueName,
                body: body
            );
        }
    }
}
