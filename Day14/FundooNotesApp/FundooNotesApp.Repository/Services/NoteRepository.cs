using FundooNotesApp.Models.DTOs.Request;
using FundooNotesApp.Models.DTOs.Response;
using FundooNotesApp.Repository.Context;
using FundooNotesApp.Repository.Interfaces;
using FundooNotesApp.Models.Entities;

namespace FundooNotesApp.Repository.Services
{
    public class NoteRepository : INoteRepository
    {
        private readonly UserContext _context;
        public NoteRepository(UserContext context)
        {
            _context = context;
        }



        // Get Note by Specific userid and user can have multiple ids so this method finds specific note of a user
        public Note GetNoteById(int noteId , int userId)
        {
            return _context.Notes.FirstOrDefault(n => n.NoteId == noteId && n.UserId == userId && n.IsActive );
        }


//creatin notes
        public NoteResponseDTO CreateNote(NoteDTO dto , int userId)
        {
            var newNote = new Note
            {
                Title = dto.Title,
                Description = dto.Description,
                IsActive = true,
                CreatedAt = dto.CreatedAt,
                UserId = userId
            };

            _context.Notes.Add(newNote);
            _context.SaveChanges();

            return new NoteResponseDTO
            {
                NoteId = newNote.NoteId,
                Title = newNote.Title,
                Description = newNote.Description,
            
            };
        }

        // Get All notes of specific user

        public List<NoteResponseDTO> GetAllNotes(int userId)
        {
            var notes = _context.Notes.Where(n => n.UserId == userId && n.IsActive).ToList();

            return notes.Select(note => new NoteResponseDTO
            {
             NoteId =note.NoteId,
             Title = note.Title,
             Description = note.Description,

            }).ToList();
            
        }


        public bool DeleteNote(int noteId , int userId)
        {
            var note = GetNoteById(noteId ,userId);

            if (note == null)
            {
                return false;
            }

            note.IsActive = false;

            note.UpdatedAt = DateTime.UtcNow;
            _context.SaveChanges();

            return true;
        }

    }
}