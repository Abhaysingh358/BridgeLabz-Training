using System;

namespace FundooNotesApp.Models.Entities
{
    public class ReminderMessage
    {
        public int ReminderId { get; set; }
        public int NoteId { get; set; }
        public int UserId { get; set; }
        public string UserEmail { get; set; } = string.Empty;
        public string UserFirstName { get; set; } = string.Empty;
        public string NoteTitle { get; set; } = string.Empty;
        public string? NoteDescription { get; set; }
        public DateTime ReminderTime { get; set; }
    }
}
