using System;

namespace FundooNotesApp.Models.Entities
{
    public class ReminderModel
    {
        public int ReminderId { get; set; }
        public int NoteId { get; set; }
        public int UserId { get; set; }
        public DateTime ReminderTime { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsCancelled { get; set; }
        public bool IsNotified { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
