using FundooNotesApp.Models.DTOs.Request;
using FundooNotesApp.Models.DTOs.Response;
using FundooNotesApp.Models.Entities;
using FundooNotesApp.Repository.Context;
using FundooNotesApp.Repository.Interfaces;

namespace FundooNotesApp.Repository.Services
{
    public class LabelRepository : ILabelRepository
    {
        private readonly UserContext _context;

        public LabelRepository(UserContext context)
        {
            _context = context;
        }

        // 1. Create a Label (Pushes directly to DB, can optionally have NoteId set)
        public LabelResponseDTO CreateLabel(LabelDTO dto, int userId)
        {
            var newLabel = new Label
            {
                LabelName = dto.LabelName,
                UserId = userId,
                NoteId = dto.NoteId
            };

            _context.Labels.Add(newLabel);
            _context.SaveChanges();

            return new LabelResponseDTO
            {
                LabelId = newLabel.LabelId,
                LabelName = newLabel.LabelName,
                UserId = newLabel.UserId,
                NoteId = newLabel.NoteId
            };
        }

        // 2. Get all labels belonging to a specific user
        public List<LabelResponseDTO> GetLabelsByUserId(int userId)
        {
            var labels = _context.Labels.Where(l => l.UserId == userId).ToList();

            return [.. labels.Select(l => new LabelResponseDTO
            {
                LabelId = l.LabelId,
                LabelName = l.LabelName,
                UserId = l.UserId,
                NoteId = l.NoteId
            })];
        }

        // 3. Permanent delete a label
        public bool DeleteLabelPermanent(int labelId, int userId)
        {
            var label = _context.Labels.FirstOrDefault(l => l.LabelId == labelId && l.UserId == userId);
            if (label == null) return false;

            _context.Labels.Remove(label);
            _context.SaveChanges();
            return true;
        }

        // 4. Update the name of a label
        public bool UpdateLabelName(int labelId, int userId, string newLabelName)
        {
            var label = _context.Labels.FirstOrDefault(l => l.LabelId == labelId && l.UserId == userId);
            if (label == null) return false;

            label.LabelName = newLabelName;
            _context.SaveChanges();
            return true;
        }

        // 5. Link an existing label to a note
        public bool AssignLabelToNote(int labelId, int noteId, int userId)
        {
            // Verify the note exists and belongs to the user
            var noteExists = _context.Notes.Any(n => n.NoteId == noteId && n.UserId == userId);
            if (!noteExists) return false;

            var label = _context.Labels.FirstOrDefault(l => l.LabelId == labelId && l.UserId == userId);
            if (label == null) return false;

            // If the label is currently unattached, bind it. 
            // If it already points to a different note, the  architecture can create a duplicate row 
            // with the same name for multi-note support, or update it here.
            label.NoteId = noteId;
            _context.SaveChanges();
            return true;
        }

        // 6. Detach a label from a note (sets NoteId back to null)
        public bool RemoveLabelFromNote(int labelId, int noteId, int userId)
        {
            var label = _context.Labels.FirstOrDefault(l => l.LabelId == labelId && l.NoteId == noteId && l.UserId == userId);
            if (label == null) return false;

            label.NoteId = null;
            _context.SaveChanges();
            return true;
        }

        // 7. Get all labels pinned to a specific note
        public List<LabelResponseDTO> GetLabelsByNoteId(int noteId, int userId)
        {
            var labels = _context.Labels.Where(l => l.NoteId == noteId && l.UserId == userId).ToList();

            return [.. labels.Select(l => new LabelResponseDTO
            {
                LabelId = l.LabelId,
                LabelName = l.LabelName,
                UserId = l.UserId,
                NoteId = l.NoteId
            })];
        }
    }
}
