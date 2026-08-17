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
            var existingUser = _userRepository.GetUserByEmail(registerDTO.Email);
            if(existingUser != null)
            {
                return null;
            }

            var newUser = new User
            {
                 FirstName = registerDTO.FirstName,
                LastName = registerDTO.LastName,
                Email = registerDTO.Email,

                // Base64 placeholder hash conversion 
                PasswordHash = Convert.ToBase64String(Encoding.UTF8.GetBytes(registerDTO.Password)),
                IsActive = 1,
                CreatedAt = DateTime.Now

            };

            newUser.PasswordHash = _passwordHasher.HashPassword(newUser,registerDTO.Password);

            var savedUser = _userRepository.CreateUser(newUser);

             return new UserResponseDTO
            {
                UserId = savedUser.UserId,
                Name = savedUser.FirstName + " " +  savedUser.LastName,
                Email = savedUser.Email
            };


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