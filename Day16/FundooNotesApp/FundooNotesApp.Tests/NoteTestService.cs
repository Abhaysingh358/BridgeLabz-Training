using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using FundooNotesApp.Business.Services;
using FundooNotesApp.Repository.Interfaces;
using FundooNotesApp.Models.DTOs.Request;
using FundooNotesApp.Models.DTOs.Response;
using System.Collections.Generic;

namespace FundooNotesApp.Tests
{
    [TestClass]
    public class NoteTestService
    {
        private Mock<INoteRepository> _mockRepo = null!;
        private NoteService _noteService = null!;
        private const int UserId = 1;

        [TestInitialize]
        public void Setup()
        {
            _mockRepo = new Mock<INoteRepository>();
            _noteService = new NoteService(_mockRepo.Object);
        }

        [TestMethod]
        public void SearchAndFilterNotes_MainSection_KeywordMatches_ReturnsFilteredNotes()
        {
            // Arrange - Default state (IsActive != false, IsArchived != true)
            var filterDto = new NoteSearchFilterDTO { Keyword = "Shopping" };
            var sampleNotes = new List<NoteResponseDTO>
            {
                new NoteResponseDTO { NoteId = 1, Title = "Grocery Shopping", Description = "Buy some fresh milk" },
                new NoteResponseDTO { NoteId = 2, Title = "Work Standup", Description = "Discuss project milestones" }
            };

            _mockRepo.Setup(r => r.GetAllNotes(UserId)).Returns(sampleNotes);

            // Act
            var result = _noteService.SearchAndFilterNotes(UserId, filterDto);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Grocery Shopping", result[0].Title);
            _mockRepo.Verify(r => r.GetAllNotes(UserId), Times.Once);
        }

        [TestMethod]
        public void SearchAndFilterNotes_TrashSection_KeywordMatches_ReturnsFilteredTrashNotes()
        {
            // Arrange - Target Trash section (IsActive == false)
            var filterDto = new NoteSearchFilterDTO { Keyword = "Deleted", IsActive = false };
            var trashNotes = new List<NoteResponseDTO>
            {
                new NoteResponseDTO { NoteId = 3, Title = "Deleted Idea", Description = "An old text note" },
                new NoteResponseDTO { NoteId = 4, Title = "Important Note", Description = "Keep this safe" }
            };

            _mockRepo.Setup(r => r.GetTrashNotes(UserId)).Returns(trashNotes);

            // Act
            var result = _noteService.SearchAndFilterNotes(UserId, filterDto);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Deleted Idea", result[0].Title);
            _mockRepo.Verify(r => r.GetTrashNotes(UserId), Times.Once);
        }

        [TestMethod]
        public void SearchAndFilterNotes_ArchiveSection_KeywordMatches_ReturnsFilteredArchiveNotes()
        {
            // Arrange - Target Archive section (IsArchived == true)
            var filterDto = new NoteSearchFilterDTO { Keyword = "Secret", IsArchived = true };
            var archivedNotes = new List<NoteResponseDTO>
            {
                new NoteResponseDTO { NoteId = 5, Title = "Secret Password", Description = "Do not share" },
                new NoteResponseDTO { NoteId = 6, Title = "Public Recipe", Description = "Bake cake" }
            };

            _mockRepo.Setup(r => r.GetArchivedNotes(UserId)).Returns(archivedNotes);

            // Act
            var result = _noteService.SearchAndFilterNotes(UserId, filterDto);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Secret Password", result[0].Title);
            _mockRepo.Verify(r => r.GetArchivedNotes(UserId), Times.Once);
        }

        [TestMethod]
        public void SearchAndFilterNotes_NoKeywordProvided_ReturnsEntireSelectedList()
        {
            // Arrange - No keyword sent
            var filterDto = new NoteSearchFilterDTO { Keyword = null };
            var sampleNotes = new List<NoteResponseDTO>
            {
                new NoteResponseDTO { NoteId = 1, Title = "Note One", Description = "Desc A" },
                new NoteResponseDTO { NoteId = 2, Title = "Note Two", Description = "Desc B" }
            };

            _mockRepo.Setup(r => r.GetAllNotes(UserId)).Returns(sampleNotes);

            // Act
            var result = _noteService.SearchAndFilterNotes(UserId, filterDto);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count); // Should return everything without filtering out items
        }
    }
}
