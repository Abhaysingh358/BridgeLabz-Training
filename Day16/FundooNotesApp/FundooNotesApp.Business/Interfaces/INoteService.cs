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

        bool DeleteNotePermanent(int noteId , int userId);

        bool ArchiveNote(int noteId , int userId);

        bool UnArchiveNote(int noteId , int userId);

        bool RestoreNote(int noteId , int userId);

        List<NoteResponseDTO> GetSortedNotedByTitile(int userId);

         List<NoteResponseDTO> GetTrashNotes(int userId);
        
        List<NoteResponseDTO> GetArchivedNotes(int userId);

         List<NoteResponseDTO> SearchAndFilterNotes(int userId , NoteSearchFilterDTO filterDTO);
       
    }
}