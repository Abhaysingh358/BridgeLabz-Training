using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using FundooNotesApp.Business.Interfaces;
using FundooNotesApp.Models.DTOs.Request;

namespace FundooNotesApp.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Enforces JWT Authentication globally across all label routes
    public class LabelController : ControllerBase
    {
        private readonly ILabelService _labelService;

        public LabelController(ILabelService labelService)
        {
            _labelService = labelService;
        }

        // Helper method to safely extract the logged-in user's ID
        private int LoggedInUserId()
        {
            return int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        }

        // 1. POST: api/label
        [HttpPost]
        public IActionResult CreateLabel(LabelDTO dto)
        {
            int userId = LoggedInUserId();
            var label = _labelService.CreateLabel(dto, userId);

            return Ok(new { Success = true, Message = "Label has been created successfully", Data = label });
        }

        // 2. GET: api/label
        [HttpGet]
        public IActionResult GetLabels()
        {
            int userId = LoggedInUserId();
            var result = _labelService.GetLabelsByUserId(userId);

            if (result == null || result.Count == 0)
            {
                return Ok(new { Success = true, Message = "No labels found for this user.", Data = result });
            }

            return Ok(new { Success = true, Data = result });
        }

        // 3. PUT: api/label/{labelId}
        [HttpPut("{labelId}")]
        public IActionResult UpdateLabelName(int labelId, [FromBody] string newLabelName)
        {
            int userId = LoggedInUserId();
            var isUpdated = _labelService.UpdateLabelName(labelId, userId, newLabelName);

            if (!isUpdated)
            {
                return BadRequest(new { Success = false, Message = "Failed to update label name. Ensure label exists and text is valid." });
            }

            return Ok(new { Success = true, Message = "Label name updated successfully." });
        }

        // 4. DELETE: api/label/{labelId}
        [HttpDelete("{labelId}")]
        public IActionResult DeleteLabel(int labelId)
        {
            int userId = LoggedInUserId();
            var isDeleted = _labelService.DeleteLabelPermanent(labelId, userId);

            if (!isDeleted)
            {
                return NotFound(new { Success = false, Message = "Label not found or unauthorized to delete." });
            }

            return Ok(new { Success = true, Message = "Label permanently deleted successfully." });
        }

        // 5. PATCH: api/label/{labelId}/assign-to-note/{noteId}
        [HttpPatch("{labelId}/assign-to-note/{noteId}")]
        public IActionResult AssignLabelToNote(int labelId, int noteId)
        {
            int userId = LoggedInUserId();
            var isAssigned = _labelService.AssignLabelToNote(labelId, noteId, userId);

            if (!isAssigned)
            {
                return BadRequest(new { Success = false, Message = "Could not assign label. Verify note/label ownership and existence." });
            }

            return Ok(new { Success = true, Message = "Label pinned to note successfully." });
        }

        // 6. PATCH: api/label/{labelId}/remove-from-note/{noteId}
        [HttpPatch("{labelId}/remove-from-note/{noteId}")]
        public IActionResult RemoveLabelFromNote(int labelId, int noteId)
        {
            int userId = LoggedInUserId();
            var isRemoved = _labelService.RemoveLabelFromNote(labelId, noteId, userId);

            if (!isRemoved)
            {
                return BadRequest(new { Success = false, Message = "Could not detach label. Verify connection links." });
            }

            return Ok(new { Success = true, Message = "Label detached from note successfully." });
        }

        // 7. GET: api/label/note/{noteId}
        [HttpGet("note/{noteId}")]
        public IActionResult GetLabelsByNoteId(int noteId)
        {
            int userId = LoggedInUserId();
            var result = _labelService.GetLabelsByNoteId(noteId, userId);

            return Ok(new { Success = true, Data = result });
        }
    }
}
