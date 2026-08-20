namespace FundooNotesApp.Models.DTOs.Response
{
    public class NoteResponseDTO
    {
        public int NoteId {get;set;}
        public string Title {get;set;} = string.Empty;

        public string ? Description {get;set;}


    }
}