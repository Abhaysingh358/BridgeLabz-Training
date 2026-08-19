using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using FundooNotesApp.Models.DTOs.Request;
using FundooNotesApp.Models.DTOs.Response;
using FundooNotesApp.Models.Entities;
using FundooNotesApp.Repository.Services;
using FundooNotesApp.Business.Interfaces;
using FundooNotesApp.Repository.Interfaces;

namespace FundooNotesApp.Business.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _repository;

        public NoteService(INoteRepository repository)
        {
            _repository = repository;
        }


        public NoteResponseDTO CreateNote(NoteDTO dto , int userId)
        {
            return _repository.CreateNote(dto , userId);
        }

        public List<NoteResponseDTO> GetNotes(int userId)
        {
            return _repository.GetAllNotes(userId);
        }

        public NoteResponseDTO GetNoteById(int noteId,int userId)
        {
            var note = _repository.GetNoteById(noteId , userId);

              if (note == null)
                {
                return null; 
                }
            return new NoteResponseDTO
            {
              NoteId = note.NoteId,
              Title = note.Title,
              Description = note.Description,  
            };
        }

        public bool DeleteNote(int noteId,int userId)
        {
            return _repository.DeleteNote(noteId,userId);
        }
    }
}