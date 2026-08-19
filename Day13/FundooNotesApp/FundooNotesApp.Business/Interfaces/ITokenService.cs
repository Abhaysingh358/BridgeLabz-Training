using FundooNotesApp.Models.Entities;

namespace FundooNotesApp.Business.Interfaces
{
    public interface ITokenService
    {
        // this generates a jwt string based on the verified user entity
        string GenerateToken(User user);
    }
}
