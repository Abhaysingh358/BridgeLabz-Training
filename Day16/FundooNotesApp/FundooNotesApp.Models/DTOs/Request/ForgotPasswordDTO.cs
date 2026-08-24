using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.Models.DTOs.Request
{
    public class ForgotPasswordDTO
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "New password is required.")]
        [StringLength(100, MinimumLength = 6,
        ErrorMessage = "Password must be at least 6 characters long.")]
    public string NewPassword { get; set; }
    }
}
