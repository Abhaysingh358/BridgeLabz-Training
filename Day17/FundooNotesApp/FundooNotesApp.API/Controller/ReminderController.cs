using FundooNotesApp.Business.Interfaces;
using FundooNotesApp.Models.DTOs.Request;
using FundooNotesApp.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace FundooNotesApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReminderController : ControllerBase
    {
        private readonly IReminderService _reminderService;
        private readonly IRabbitMQService _rabbitMQService;
        private readonly INoteService _noteService;

        public ReminderController(
            IReminderService reminderService,
            IRabbitMQService rabbitMQService,
            INoteService noteService)
        {
            _reminderService = reminderService;
            _rabbitMQService = rabbitMQService;
            _noteService = noteService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateReminder([FromBody] CreateReminderDto reminderDTO)
        {
            int userId = GetUserId();
            string? email = User.FindFirstValue(ClaimTypes.Email);

            var response = await _reminderService.CreateReminderAsync(reminderDTO, userId);

            string noteTitle = "Untitled Note";
            string? noteDescription = null;
            try
            {
                var note = _noteService.GetNoteById(reminderDTO.NoteId, userId);
                if (note != null)
                {
                    noteTitle = note.Title;
                    noteDescription = note.Description;
                }
            }
            catch (Exception)
            {
                // Fallback if note fetching fails
            }

            var message = new ReminderMessage
            {
                ReminderId = response.ReminderId,
                NoteId = response.NoteId,
                UserId = userId,
                UserEmail = email ?? string.Empty,
                UserFirstName = string.Empty,
                NoteTitle = noteTitle,
                NoteDescription = noteDescription,
                ReminderTime = response.ReminderTime
            };

            // Publish message to RabbitMQ
            await _rabbitMQService.PublishReminderAsync(message);

            return CreatedAtAction(nameof(GetReminderById), new { id = response.ReminderId }, response);
        }

        [HttpGet]
        public async Task<IActionResult> GetReminders()
        {
            int userId = GetUserId();
            var response = await _reminderService.GetAllRemindersAsync(userId);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetReminderById(int id)
        {
            int userId = GetUserId();
            var response = await _reminderService.GetReminderByIdAsync(id, userId);

            if (response == null)
            {
                return NotFound("Reminder not found.");
            }

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReminder(int id)
        {
            int userId = GetUserId();
            bool deleted = await _reminderService.DeleteReminderAsync(id, userId);

            if (!deleted)
            {
                return NotFound("Reminder not found.");
            }

            return NoContent();
        }

        private int GetUserId()
        {
            string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(userId))
            {
                throw new UnauthorizedAccessException("User ID not found in token.");
            }

            return int.Parse(userId);
        }
    }
}