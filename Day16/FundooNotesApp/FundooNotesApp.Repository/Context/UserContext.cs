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

        public DbSet<Note>  Notes {get ;set;}

        public DbSet<Label> Labels {get;set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
               // Configures the Navigation Property Cascade Delete rule
            modelBuilder.Entity<Label>().HasOne(l => l.Note)
            .WithMany(n => n.Labels) // This connects it to the collection i  added to Note.cs
            .HasForeignKey(l => l.NoteId)
            .OnDelete(DeleteBehavior.Cascade);

        }
    }
}