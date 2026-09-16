using System.Collections.Generic;
using MyNotesApp.Models;

namespace MyNotesApp.Services
{
    public class NotesService : INotesService
    {
        private static readonly List<Note> _notes = new List<Note>();

        public IReadOnlyList<Note> GetAll() => _notes;

        public void Add(Note note) => _notes.Add(note);
    }
}