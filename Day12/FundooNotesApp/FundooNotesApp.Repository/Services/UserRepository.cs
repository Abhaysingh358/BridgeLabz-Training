using FundooNotesApp.Models.Entities;
using FundooNotesApp.Repository.Context;
using FundooNotesApp.Repository.Interfaces;
using Microsoft.Identity.Client;

namespace FundooNotesApp.Repository.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _userContext ;
        public UserRepository(UserContext userContext)
        {
            _userContext = userContext;
        }


        public User GetUserByEmail(string email)
        {
            return _userContext.Users.FirstOrDefault(u => u.Email == email && u.IsActive==1);

        }

        public User CreateUser(User user)
        {
            _userContext.Users.Add(user);
            _userContext.SaveChanges(); // direct commit to database
            return user;

        }

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