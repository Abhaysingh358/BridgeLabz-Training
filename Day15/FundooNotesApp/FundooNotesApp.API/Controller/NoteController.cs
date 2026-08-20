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


        // Soft Delete / Move to Trash
        [HttpPatch("{noteId}/moveToTrash")]
        [Authorize]
        public IActionResult DeleteNote(int noteId)
        {
            int userId = LoggedInUserId();
           var result = _service.DeleteNote(noteId , userId);
            if (!result)
            {
                return NotFound(new {Message = "Note has not Found"});
            }

            return Ok(new{Message = "Note deleted Succesfully"});
        }


        //Delete Note ForEver
        [HttpDelete("{noteId}")]
        [Authorize]
        public IActionResult DeleteNotePermanent(int noteId)
        {
            int userId = LoggedInUserId();

            var result = _service.DeleteNotePermanent(noteId , userId);
            if (!result)
            {
                return NotFound("Note Has Not Found");
            }

            return Ok(new {Message = "Note Deleted Permanently"});
        }


        //Archive a Note
        [HttpPatch("{noteId}/archive")]
        [Authorize]
        public IActionResult ArchiveNote(int noteId)
        {
            int userId = LoggedInUserId();

            bool IsNoteArchived = _service.ArchiveNote(noteId , userId);

            if(!IsNoteArchived) return NotFound(new{Message = "Note not Found"});

            return Ok(new{Success = true , Message = "Note Archived Succesfully"});
        }


        // UnArchive A Note
        [HttpPatch("{noteId}/unarchive")]
        [Authorize]
        public IActionResult UnArchiveNote(int noteId)
        {
            int userId = LoggedInUserId();

            bool IsUnArchived = _service.UnArchiveNote(noteId ,userId);

             if (!IsUnArchived)
            {
                return NotFound(new { message = "Note is not found." });
            }

            return Ok(new { message = "Note unarchived successfully." });
        }


        //restoer a Note
        [HttpPatch("{noteId}/restore")]
        [Authorize]
        public IActionResult RestoreNote(int noteId)
        {
            int userId = LoggedInUserId();

            bool IsRestore = _service.RestoreNote(noteId , userId);

            if (!IsRestore)
            {
                return NotFound(new { message = "Note is not found." });
            }

            return Ok(new { message = "Note restored successfully." });
        }



    }
}