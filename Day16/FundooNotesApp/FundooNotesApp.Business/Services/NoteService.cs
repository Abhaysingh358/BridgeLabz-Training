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


        // soft delete or trash 
        public bool DeleteNote(int noteId,int userId)
        {
            return _repository.DeleteNote(noteId,userId);
        }

        // permanent delete 

        public bool DeleteNotePermanent(int noteId , int userId)
        {
            return _repository.DeleteNotePermanent(noteId ,userId);
        }


        // Archive Note
       public  bool ArchiveNote(int noteId , int userId)
        {
            return _repository.ArchiveNote(noteId , userId);
        }

        //Restore Archive Note
        public bool UnArchiveNote(int noteId , int userId)
        {
            return _repository.UnArchiveNote(noteId ,userId);
        }



        // Restoring Note from Trash
        public bool RestoreNote(int noteId , int userId)
        {
            return _repository.RestoreNote(noteId ,userId);
        }

        // Sorted Notes By Title

        public List<NoteResponseDTO> GetSortedNotedByTitile(int userId)
        {
            var notes = _repository.GetAllNotes(userId);

            return notes.OrderByDescending(note => note.Title).ToList();
        }

         // Get Trash Notes
         public List<NoteResponseDTO> GetTrashNotes(int userId)
        {
           return _repository.GetTrashNotes(userId);
            
        }

        // Get Archived Notes
        public List<NoteResponseDTO> GetArchivedNotes(int userId)
        {
            return _repository.GetArchivedNotes(userId);
        }


        // Search and ilter Notes in both title and description
        public List<NoteResponseDTO> SearchAndFilterNotes(int userId , NoteSearchFilterDTO filterDTO)
        {
            List<NoteResponseDTO> words ;

            // 1. Route to  existing repository methods based on the DTO flags
            if (filterDTO.IsActive == false)
            {
                 // User explicitly wants to search inside the TRASH section
                words = _repository.GetTrashNotes(userId);
            }
            else if (filterDTO.IsArchived == true)
            {
            // User explicitly wants to search inside the ARCHIVE section
             words = _repository.GetArchivedNotes(userId);
            }
            else
            {
                // Default: Search the main, active, unarchived notes section
                words = _repository.GetAllNotes(userId);
            }

            if (!string.IsNullOrWhiteSpace(filterDTO.Keyword))
            {
                var newKeyword = filterDTO.Keyword.Trim().ToLower();

                words = words.Where(n => n.Title.ToLower().Contains(newKeyword) || (n.Description != null && n.Description.ToLower().Contains(newKeyword))).ToList();
            }

           

            return words;
        }

    }
}