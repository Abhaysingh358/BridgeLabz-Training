using System.ComponentModel.DataAnnotations;

namespace ContactApp.Models.DTO
{
    public class ContactCreatDTO
    {
    [Required]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    public string LastName { get; set; } = string.Empty;
    [Required , EmailAddress]
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    }
}