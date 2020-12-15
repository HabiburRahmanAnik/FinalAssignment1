using FinalTermAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermAssignment.DataAcces
{
    class ModifyEventDataAccess
    {
        DataAcces dataAcces;
        public ModifyEventDataAccess()
        {
            this.dataAcces = new DataAcces();
        }

        public int ModofyNotes(Note note)
        {
            string query = "UPDATE Notes SET Note='" + note.Note1 + "',Important='" + note.Important + "',Date='" + note.Date + "' WHERE Id="+note.Id;
            int result = this.dataAcces.ExecuteQuery(query);
            return result;
        }
    }
}
