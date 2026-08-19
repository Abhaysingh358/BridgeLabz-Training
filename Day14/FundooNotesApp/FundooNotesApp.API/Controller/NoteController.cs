using System.Security.Claims;
using FundooNotesApp.Business.Interfaces;
using FundooNotesApp.Business.Services;
using FundooNotesApp.Models.DTOs.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FundooNotesApp.API.Controller
{
    [ApiController]
    [Route("api/[Controller]")]
    public class NoteController : ControllerBase
    {
        private readonly INoteService _service;

        public NoteController(INoteService service)
        {
            _service = service;
        }

        [Authorize]
        private int LoggedInUserId()
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier ));
            return userId;
        }

        [HttpPost]
        [Authorize]
        public IActionResult CreateNote(NoteDTO dto)
        {
            int userId = LoggedInUserId();
            var note = _service.CreateNote(dto ,userId);

            return Ok(new{Success = true , Message = "Note has been Created" , Data = note});
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetNotes()
        {
            int userId = LoggedInUserId();
            var result = _service.GetNotes(userId);
            if (result == null)
            {
                return Ok(new{Success=true , Message = "No note has been Found"});
            }

            return Ok(new{Success = true , Data = result});
        }


        [HttpGet("{noteId}")]
        [Authorize]
        public IActionResult GetNoteById(int noteId)
        {
            int userId = LoggedInUserId();
            var result = _service.GetNoteById(noteId , userId);
            if(result==null) return NotFound();
            return Ok(result);
        }


        [HttpPost("{noteId}")]
        [Authorize]
        public IActionResult DeleteNote(int noteId)
        {
            int userId = LoggedInUserId();
           var result = _service.DeleteNote(noteId , userId);
            if (!result)
            {
                return NotFound("Note has not Found");
            }

            return Ok("Note deleted Succesfully");
        }


    }
}