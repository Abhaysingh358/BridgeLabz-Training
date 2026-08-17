using FundooNotesApp.Models.Entities;

namespace FundooNotesApp.Repository.Interfaces
{
    public interface IUserRepository
    {
        User GetUserByEmail(string email);

        User CreateUser (User user);

        bool UpdateUserPassword(string email , string newpassword);
    }
}