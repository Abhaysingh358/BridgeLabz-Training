using FundooNotesApp.Models.DTOs.Request;
using FundooNotesApp.Models.DTOs.Response;
using FundooNotesApp.Models.Entities;

namespace FundooNotesApp.Repository.Interfaces
{
    public interface IUserRepository
    {
        User GetUserByEmail(string email);

        UserResponseDTO RegisterUser (RegisterDTO dto);

        bool UpdateUserPassword(string email , string newpassword);
    }
}