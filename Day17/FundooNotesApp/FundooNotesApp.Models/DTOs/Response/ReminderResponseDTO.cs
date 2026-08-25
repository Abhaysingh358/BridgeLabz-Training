using System;

namespace FundooNotesApp.Models.DTOs.Response
{
    public class ReminderResponseDTO
    {
        public int ReminderId { get; set; }
        public int NoteId { get; set; }
        public DateTime ReminderTime { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsCancelled { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
