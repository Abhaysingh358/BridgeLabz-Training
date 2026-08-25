namespace FundooNotesApp.Models.DTOs.Request
{
    public class NoteSearchFilterDTO
    {
        // Text keyword to search across both Title and Description
        public string? Keyword { get; set; }

        // Optional specific filters
        public bool? IsActive { get; set; }
        public bool? IsArchived { get; set; }
    }
}
