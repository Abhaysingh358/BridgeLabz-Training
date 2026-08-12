using ContactApp.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace ContactApp.Repository.Data
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options)
        {
            
        }

        public DbSet<Contact> Contacts {get;set;}
    }
}