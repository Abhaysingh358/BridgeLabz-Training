using FundooNotesApp.Models.DTOs.Request;
using FundooNotesApp.Models.DTOs.Response;
using FundooNotesApp.Models.Entities;

namespace FundooNotesApp.Repository.Interfaces
{
    public interface INoteRepository
    {
        NoteResponseDTO CreateNote (NoteDTO dto , int userId);

        List<NoteResponseDTO> GetAllNotes(int userId);

        Note GetNoteById(int noteId , int userId);

        bool DeleteNote(int nodeId , int userId);


      
    }
}