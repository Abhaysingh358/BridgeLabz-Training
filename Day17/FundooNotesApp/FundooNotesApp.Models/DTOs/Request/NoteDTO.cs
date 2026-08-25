using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.Models.DTOs.Request
{
    public class NoteDTO
    {
        [Required (ErrorMessage  = "Title is Required")]
        [StringLength(200 , ErrorMessage = "Charactrs Can not be more than 200")]
        public string Title {get;set;}
        public string ? Description {get;set;}

        public DateTime CreatedAt {get;set;}



    }
}