using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FundooNotesApp.Models.Entities
{
    public class Label
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LabelId { get; set; }

        [Required]
        [StringLength(100)]
        public string LabelName { get; set; } = string.Empty;

        // Foreign Key linking the label to its creator/owner
        [Required]
        public int UserId { get; set; }

        // Optional Foreign Key link to a Note. 
        // Making this nullable (int?) allows users to create labels first without attaching them to a note right away.
        public int? NoteId { get; set; }

        // Navigation property back to the target Note  , it supports eager loading
        [ForeignKey("NoteId")]
        public virtual Note? Note { get; set; }
    }
}
