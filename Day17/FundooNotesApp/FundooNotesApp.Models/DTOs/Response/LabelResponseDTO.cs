namespace FundooNotesApp.Models.DTOs.Response
{
    public class LabelResponseDTO
    {
        public int LabelId { get; set; }
        public string LabelName { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int? NoteId { get; set; }
    }
}
