using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Категории заметок.
    /// <summary>
    public enum NoteCategory
    {
       Other = 1,
        Documents,
        Finance,
        HealthAndSport,
        Home,
        People,
        Work
    }
}
