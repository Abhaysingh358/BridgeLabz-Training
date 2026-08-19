using FundooNotesApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FundooNotesApp.Repository.Context
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users {get;set;}
    }
}