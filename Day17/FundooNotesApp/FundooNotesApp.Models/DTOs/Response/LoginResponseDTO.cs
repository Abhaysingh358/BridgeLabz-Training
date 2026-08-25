namespace FundooNotesApp.Models.DTOs.Response
{
    public class LoginResponseDTO
    {
    public int UserId { get; set; }
    public string Name { get; set; }  // combining first and last name 
    public string Email { get; set; }

    public string Token {get;set;}



}
}