using FundooNotesApp.Business.Interfaces;
using FundooNotesApp.Models.DTOs.Request;
using FundooNotesApp.Models.DTOs.Response;
using FundooNotesApp.Repository.Interfaces;

namespace FundooNotesApp.Business.Services
{
    public class LabelService : ILabelService
    {
        private readonly ILabelRepository _repository;

        public LabelService(ILabelRepository repository)
        {
            _repository = repository;
        }

        public LabelResponseDTO CreateLabel(LabelDTO dto, int userId)
        {
            return _repository.CreateLabel(dto, userId);
        }

        public List<LabelResponseDTO> GetLabelsByUserId(int userId)
        {
            return _repository.GetLabelsByUserId(userId);
        }

        public bool DeleteLabelPermanent(int labelId, int userId)
        {
            return _repository.DeleteLabelPermanent(labelId, userId);
        }

        public bool UpdateLabelName(int labelId, int userId, string newLabelName)
        {
            // Business Rule: Ensure the new label name isn't just whitespace
            if (string.IsNullOrWhiteSpace(newLabelName))
            {
                return false;
            }

            return _repository.UpdateLabelName(labelId, userId, newLabelName.Trim());
        }

        public bool AssignLabelToNote(int labelId, int noteId, int userId)
        {
            return _repository.AssignLabelToNote(labelId, noteId, userId);
        }

        public bool RemoveLabelFromNote(int labelId, int noteId, int userId)
        {
            return _repository.RemoveLabelFromNote(labelId, noteId, userId);
        }

        public List<LabelResponseDTO> GetLabelsByNoteId(int noteId, int userId)
        {
            return _repository.GetLabelsByNoteId(noteId, userId);
        }
    }
}
