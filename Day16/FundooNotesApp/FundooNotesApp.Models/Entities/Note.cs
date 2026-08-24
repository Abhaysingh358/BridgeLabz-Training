using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace FundooNotesApp.Models.Entities
{
    public class Note
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NoteId {get;set;}

        [Required]
        [StringLength(200)]
        public string  Title {get ; set;} 

        [Required]
        public string ? Description {get ;set ;}

        public bool IsActive {get;set;}

        public bool IsArchived {get ; set;} = false;

        public DateTime CreatedAt {get;set;} = DateTime.UtcNow;

        public DateTime UpdatedAt {get;set;} = DateTime.UtcNow;

        [Required]
        public int UserId {get;set;}


        public virtual ICollection<Label> Labels { get; set; } = new List<Label>();
 

    }
}