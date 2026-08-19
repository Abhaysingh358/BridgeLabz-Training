using FundooNotesApp.Models.DTOs.Request;
using FundooNotesApp.Models.DTOs.Response;
namespace FundooNotesApp.Business.Interfaces
{
    public interface INoteService
    {
         NoteResponseDTO CreateNote(NoteDTO createNoteDTO,int userId);

        List<NoteResponseDTO> GetNotes(int userId);

        NoteResponseDTO GetNoteById(int noteId,int userId);

        bool DeleteNote(int noteId,int userId);
    }
}