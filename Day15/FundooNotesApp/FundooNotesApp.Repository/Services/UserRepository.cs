using FundooNotesApp.Models.Entities;
using FundooNotesApp.Repository.Context;
using FundooNotesApp.Repository.Interfaces;
using FundooNotesApp.Models.DTOs.Request;
using Microsoft.Identity.Client;
using FundooNotesApp.Models.DTOs.Response;
using Microsoft.AspNetCore.Identity;
using System.Text;

namespace FundooNotesApp.Repository.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _userContext ;
        private readonly PasswordHasher<User> _passwordHasher;
        public UserRepository(UserContext userContext )
        {
            _userContext = userContext;
            _passwordHasher = new PasswordHasher<User>();
        }


        public User GetUserByEmail(string email)
        {

            return _userContext.Users.FirstOrDefault(u => u.Email == email && u.IsActive==1);

        }


        //creating objects in repo and return as response 
        public UserResponseDTO RegisterUser (RegisterDTO dto)
        {
            var existingUser = GetUserByEmail(dto.Email);
            if(existingUser != null)
            {
                return  null;
            }

            var newUser = new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                PasswordHash = Convert.ToBase64String(Encoding.UTF8.GetBytes(dto.Password)),
                IsActive = 1,
                CreatedAt = DateTime.Now
            };
            
            _userContext.Users.Add(newUser);
            _userContext.SaveChanges(); // direct commit to database


            return new UserResponseDTO
            {
                UserId = newUser.UserId,
                 Name = newUser.FirstName + " " +  newUser.LastName,
                 Email = newUser.Email
            };

        }

        // Login Method return LoginResponse DTO , DTOs are also models 
        

        public bool UpdateUserPassword(string email , string newpassword)
        {
            var user = _userContext.Users.FirstOrDefault(u => u.Email==email && u.IsActive==1);

            if (user == null)
            {
                return false;
            }

            user.PasswordHash = newpassword;
            user.UpdatedAt  = DateTime.Now;

            _userContext.SaveChanges();
            return true;
        }

    }
}