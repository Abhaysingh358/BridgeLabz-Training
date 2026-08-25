using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using FundooNotesApp.Repository.Context;
using FundooNotesApp.Repository.Services;
using FundooNotesApp.Models.Entities;
using FundooNotesApp.Models.DTOs.Request;
using System;
using System.Linq;

namespace FundooNotesApp.Tests
{
    [TestClass]
    public class NoteRepositoryTests
    {
        private UserContext _context = null!;
        private NoteRepository _repository = null!;

        [TestInitialize]
        public void Setup()
        {
            // Create a unique database name per test run to prevent leftover data interference
            var options = new DbContextOptionsBuilder<UserContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new UserContext(options);
            _repository = new NoteRepository(_context);
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Destroy database context after each test to free up RAM
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        [TestMethod]
        public void CreateNote_ValidInput_SavesNoteToDatabase()
        {
            // Arrange
            int userId = 42;
            var noteDto = new NoteDTO 
            { 
                Title = "Repo Test Note", 
                Description = "Testing database interaction",
                CreatedAt = DateTime.UtcNow
            };

            // Act
            var result = _repository.CreateNote(noteDto, userId);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.NoteId > 0, "The database should generate a positive primary key.");
            
            // Query the in-memory context directly to check if the record exists
            var dbNote = _context.Notes.FirstOrDefault(n => n.NoteId == result.NoteId);
            Assert.IsNotNull(dbNote);
            Assert.AreEqual("Repo Test Note", dbNote.Title);
            Assert.IsTrue(dbNote.IsActive);
        }

        [TestMethod]
        public void DeleteNote_ExistingNote_PerformsSoftDelete()
        {
            // Arrange
            int noteId = 99;
            int userId = 42;
            
            // Seed a live active note into our memory bank
            var existingNote = new Note
            {
                NoteId = noteId,
                UserId = userId,
                Title = "Active Note",
                Description = "Will be deleted",
                IsActive = true,
                IsArchived = false
            };
            _context.Notes.Add(existingNote);
            _context.SaveChanges();

            // Act
            bool isSuccess = _repository.DeleteNote(noteId, userId);

            // Assert
            Assert.IsTrue(isSuccess);
            
            // Check that the note was NOT dropped, but turned flag-inactive (Soft Deleted)
            var dbNote = _context.Notes.FirstOrDefault(n => n.NoteId == noteId);
            Assert.IsNotNull(dbNote);
            Assert.IsFalse(dbNote.IsActive, "The note should have IsActive set to false.");
        }

        [TestMethod]
        public void DeleteNote_NonExistentNote_ReturnsFalse()
        {
            // Arrange
            int invalidNoteId = 999;
            int userId = 1;

            // Act
            bool isSuccess = _repository.DeleteNote(invalidNoteId, userId);

            // Assert
            Assert.IsFalse(isSuccess, "Soft delete should return false if the entity is missing.");
        }

    [TestMethod]
    public void ArchiveNote_ValidNote_SetsArchiveFlagTrue()
    {
        // Arrange
        int noteId = 10;
        int userId = 2;
    
        // FIX: Added 'Description' here so it passes the [Required] validation check
        var activeNote = new Note 
        { 
            NoteId = noteId, 
            UserId = userId, 
            Title = "Archive Me", 
            Description = "This is a required field description", 
            IsActive = true, 
            IsArchived = false 
        };
    
        _context.Notes.Add(activeNote);
        _context.SaveChanges(); // This will no longer throw an exception!

        // Act
        bool result = _repository.ArchiveNote(noteId, userId);

        // Assert
        Assert.IsTrue(result);
        var updatedNote = _context.Notes.Find(noteId);
        Assert.IsNotNull(updatedNote);
        Assert.IsTrue(updatedNote.IsArchived);
    }

    }
}
