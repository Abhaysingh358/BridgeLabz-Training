using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FundooNotesApp.Models.Entities
{
    [Table("Reminders")]
    public class Reminder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReminderId { get; set; }

        [Required]
        public int NoteId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime ReminderTime { get; set; }

        public bool IsCompleted { get; set; } = false;

        public bool IsCancelled { get; set; } = false;

        public bool IsNotified { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
