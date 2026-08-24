using System.Text;
using FundooNotesApp.Business.Interfaces;
using FundooNotesApp.Models.DTOs.Request;
using FundooNotesApp.Models.DTOs.Response;
using FundooNotesApp.Repository.Interfaces;
using FundooNotesApp.Models.Entities;
using FundooNotesApp.Repository.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Query;

namespace FundooNotesApp.Business.Services
{
    public class AuthUserService : IAuthUser
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;
        private readonly PasswordHasher<User> _passwordHasher;

        public AuthUserService(ITokenService tokenservice , IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _tokenService = tokenservice;
            _passwordHasher = new PasswordHasher<User>();
        }

        public  UserResponseDTO RegisterUser(RegisterDTO registerDTO)
        {
           return _userRepository.RegisterUser(registerDTO);

        }

        public LoginResponseDTO LoginUser(LoginDTO loginDto)
        {
            var user = _userRepository.GetUserByEmail(loginDto.Email);
             if (user == null)
            {
                return null;
            }
            
            // result of hashing password whether they are same or not 
            var userPassword =_passwordHasher.VerifyHashedPassword(user ,user.PasswordHash ,loginDto.Password);

            if (userPassword == PasswordVerificationResult.Failed)
            {
                return null;
            }

            string genratedToken =  _tokenService.GenerateToken(user);
            return new LoginResponseDTO
            {
               
                UserId = user.UserId,
                Name = user.FirstName+ " " + user.LastName,
                Email = user.Email,
                Token = genratedToken
                
            };
        }

        public bool ForgotPassword(ForgotPasswordDTO forgotPasswordDto)
        {
            var user = _userRepository.GetUserByEmail(forgotPasswordDto.Email);

            if (user == null)
            {
                return false;
            }

            var newPasswordHash = _passwordHasher.HashPassword(user ,forgotPasswordDto.NewPassword);

            return _userRepository.UpdateUserPassword(forgotPasswordDto.Email ,newPasswordHash);

        }
    }
}