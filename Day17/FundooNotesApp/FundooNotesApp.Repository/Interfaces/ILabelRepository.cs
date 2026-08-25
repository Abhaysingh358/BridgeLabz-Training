using FundooNotesApp.Models.DTOs.Request;
using FundooNotesApp.Models.DTOs.Response;

namespace FundooNotesApp.Repository.Interfaces
{
    public interface ILabelRepository
    {
        // 1. Core Label Management
        LabelResponseDTO CreateLabel(LabelDTO dto, int userId);

        List<LabelResponseDTO> GetLabelsByUserId(int userId);

        bool DeleteLabelPermanent(int labelId, int userId);

        bool UpdateLabelName(int labelId, int userId, string newLabelName);


        // 2. Note and Label Linking Operations
        bool AssignLabelToNote(int labelId, int noteId, int userId);

        bool RemoveLabelFromNote(int labelId, int noteId, int userId);

        List<LabelResponseDTO> GetLabelsByNoteId(int noteId, int userId);
        
    }
}
