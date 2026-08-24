// using System;
// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;

// namespace FundooNotesApp.Models.Models
// {
//        public class User
//     {
      
//         [Required]
//         [StringLength(50)]
//         public string FirstName { get; set; }

//         [Required]
//         [StringLength(50)]
//         public string LastName { get; set; }

//         [Required]
//         [StringLength(100)]
//         public string Email { get; set; }

//         [Required]
//         [StringLength(255)] // Larger size to handle secure hashed strings 
//         public string PasswordHash { get; set; }

//         public int IsActive {get;set;} = 1;

//         public DateTime CreatedAt { get; set; } = DateTime.Now;
        
//         public DateTime? UpdatedAt { get; set; } 
//     }
// }
