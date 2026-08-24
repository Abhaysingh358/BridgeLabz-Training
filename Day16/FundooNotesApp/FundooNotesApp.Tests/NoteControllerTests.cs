using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using FundooNotesApp.API.Controller;
using FundooNotesApp.Business.Interfaces;
using FundooNotesApp.Models.DTOs.Request;
using FundooNotesApp.Models.DTOs.Response;
using System.Collections.Generic;

namespace FundooNotesApp.Tests
{
    [TestClass]
    public class NoteControllerTests
    {
        private Mock<INoteService> _mockService = null!;
        private NoteController _controller = null!;
        private const int ExpectedUserId = 123; // Simulated Logged-In User ID

        [TestInitialize]
        public void Setup()
        {
            // 1. Initialize the fake/mocked Service Layer
            _mockService = new Mock<INoteService>();

            // 2. Instantiate the real controller injecting our fake service
            _controller = new NoteController(_mockService.Object);

            // 3. Mock the User JWT Token context inside the controller controller context
            var claims = new List<Claim> 
            { 
                new Claim(ClaimTypes.NameIdentifier, ExpectedUserId.ToString()) 
            };
            var identity = new ClaimsIdentity(claims, "TestAuthentication");
            var claimsPrincipal = new ClaimsPrincipal(identity);

            // 4. Attach the mock identity context to the Controller Instance
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = claimsPrincipal }
            };
        }

        [TestMethod]
        public void CreateNote_ValidPayload_ReturnsOkWithSuccessData()
        {
            // Arrange
            var payloadDto = new NoteDTO { Title = "API Test", Description = "Testing Controller Routing" };
            var serviceResponse = new NoteResponseDTO { NoteId = 1, Title = payloadDto.Title, Description = payloadDto.Description };

            _mockService.Setup(s => s.CreateNote(payloadDto, ExpectedUserId)).Returns(serviceResponse);

            // Act
            var httpResult = _controller.CreateNote(payloadDto);

            // Assert
            Assert.IsInstanceOfType(httpResult, typeof(OkObjectResult));
            var okResult = (OkObjectResult)httpResult;
            Assert.IsNotNull(okResult.Value);
            
            _mockService.Verify(s => s.CreateNote(payloadDto, ExpectedUserId), Times.Once);
        }

        [TestMethod]
        public void GetNoteById_NoteDoesNotExist_Returns404NotFound()
        {
            // Arrange
            int targetedNoteId = 999;
            // Force service to return null when requested note doesn't match
            _mockService.Setup(s => s.GetNoteById(targetedNoteId, ExpectedUserId)).Returns((NoteResponseDTO)null!);

            // Act
            var httpResult = _controller.GetNoteById(targetedNoteId);

            // Assert
            Assert.IsInstanceOfType(httpResult, typeof(NotFoundResult));
        }

        [TestMethod]
        public void SearchNotes_MatchingResultsFound_ReturnsOkWithNotesList()
        {
            // Arrange
            var filter = new NoteSearchFilterDTO { Keyword = "Work" };
            var mockFilteredResults = new List<NoteResponseDTO> 
            { 
                new NoteResponseDTO { NoteId = 5, Title = "Work Meeting" } 
            };

            _mockService.Setup(s => s.SearchAndFilterNotes(ExpectedUserId, filter)).Returns(mockFilteredResults);

            // Act
            var httpResult = _controller.SearchNotes(filter);

            // Assert
            Assert.IsInstanceOfType(httpResult, typeof(OkObjectResult));
            var okResult = (OkObjectResult)httpResult;
            var payload = okResult.Value as List<NoteResponseDTO>;
            Assert.IsNotNull(payload);
            Assert.AreEqual(1, payload.Count);
        }

        [TestMethod]
        public void SearchNotes_NoMatchesFound_Returns200OkWithMessagePayload()
        {
            // Arrange
            var filter = new NoteSearchFilterDTO { Keyword = "EmptySearchString" };
            var mockEmptyList = new List<NoteResponseDTO>(); // 0 items

            _mockService.Setup(s => s.SearchAndFilterNotes(ExpectedUserId, filter)).Returns(mockEmptyList);

            // Act
            var httpResult = _controller.SearchNotes(filter);

            // Assert
            Assert.IsInstanceOfType(httpResult, typeof(OkObjectResult));
            _mockService.Verify(s => s.SearchAndFilterNotes(ExpectedUserId, filter), Times.Once);
        }
    }
}
