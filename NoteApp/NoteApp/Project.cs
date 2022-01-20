using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс, который хранит список заметок.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список заметок
        /// </summary>
        public List<Note> Notes = new List<Note>();

        /// <summary>
        /// Хранение заметки
        /// </summary>
        public int CurrentIndexNote { get; set; }

        public List<Note> SortByEditing(List<Note> _notesToSort)
        {
            return _notesToSort = _notesToSort.OrderByDescending(item => item.ModifiedTime).ToList();
        }
        public List<Note> SortByEditing(List<Note> _notesToSort, NoteCategory category)
        {
            return _notesToSort = _notesToSort.Where(item => item.Category == category)
            .OrderByDescending(item => item.ModifiedTime).ToList();
        }
    }
}

