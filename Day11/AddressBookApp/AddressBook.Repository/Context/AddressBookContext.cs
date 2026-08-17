
using AddressBook.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace AddressBook.Repository
{
    public class AddressBookContext : DbContext
    {
        public AddressBookContext(DbContextOptions<AddressBookContext> options) : base(options)
        {
            
        }

        public DbSet<Contact> Contacts {get;set;}
    }
}