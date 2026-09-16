using MyNotesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotesApp.Services
{
    public interface INotesService
    {
        IReadOnlyList<Note> GetAll();
        void Add(Note note);
    }
}
