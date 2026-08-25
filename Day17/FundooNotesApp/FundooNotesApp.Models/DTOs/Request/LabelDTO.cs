using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.Models.DTOs.Request
{
    public class LabelDTO
    {
        [Required(ErrorMessage = "Label name is required.")]
        [StringLength(100, ErrorMessage = "Label name cannot exceed 100 characters.")]
        public string LabelName { get; set; } = string.Empty;

        // Keep this nullable. If passed, we attach it to a note immediately.
        // If null, it creates a standalone label.
        public int? NoteId { get; set; }
    }
}
