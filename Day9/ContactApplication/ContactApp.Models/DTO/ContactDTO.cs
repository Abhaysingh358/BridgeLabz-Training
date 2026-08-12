namespace ContactApp.Models.DTO
{
    public class ContactDTO
    {
    public int Id { get; set; } // Safe to return now
    public string FullName { get; set; } = string.Empty; // combine names for the UI
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    }
}