using MyNotesApp.Models;
using MyNotesApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotesApp.ViewModels
{
    public class NotesViewModel
    {
        private readonly INotesService _notesService;

        public ObservableCollection<Note> Notes { get; } = new ObservableCollection<Note>();

        public NotesViewModel(INotesService notesService)
        {
            _notesService = notesService;
            foreach (var n in _notesService.GetAll())
                Notes.Add(n);
        }

        public void AddNote(string text)
        {
            var note = new Note { Text = text };
            _notesService.Add(note);
            Notes.Add(note);
        }
    }
}
