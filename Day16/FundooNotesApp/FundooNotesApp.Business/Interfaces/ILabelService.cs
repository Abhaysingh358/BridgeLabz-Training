using FundooNotesApp.Models.DTOs.Request;
using FundooNotesApp.Models.DTOs.Response;
using System.Collections.Generic;

namespace FundooNotesApp.Business.Interfaces
{
    public interface ILabelService
    {
        LabelResponseDTO CreateLabel(LabelDTO dto, int userId);

        List<LabelResponseDTO> GetLabelsByUserId(int userId);

        bool DeleteLabelPermanent(int labelId, int userId);

        bool UpdateLabelName(int labelId, int userId, string newLabelName);

        bool AssignLabelToNote(int labelId, int noteId, int userId);

        bool RemoveLabelFromNote(int labelId, int noteId, int userId);
        
        List<LabelResponseDTO> GetLabelsByNoteId(int noteId, int userId);
    }
}
