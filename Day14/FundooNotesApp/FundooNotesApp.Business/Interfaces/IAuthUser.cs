using FundooNotesApp.Models.DTOs.Response;
using FundooNotesApp.Models.DTOs.Request;

namespace FundooNotesApp.Business.Interfaces
{
    public interface IAuthUser
    {
         UserResponseDTO RegisterUser(RegisterDTO registerDto);

        LoginResponseDTO LoginUser(LoginDTO loginDto);

        bool ForgotPassword(ForgotPasswordDTO forgotPasswordDto);
    }
}