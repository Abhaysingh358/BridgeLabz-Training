using System;
using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.Models.DTOs.Request
{
    public class CreateReminderDto
    {
        [Required(ErrorMessage = "NoteId is required")]
        public int NoteId { get; set; }

        [Required(ErrorMessage = "ReminderTime is required")]
        public DateTime ReminderTime { get; set; }
    }
}
