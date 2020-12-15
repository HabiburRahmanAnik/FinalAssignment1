using FinalTermAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermAssignment.DataAcces
{
    class UpdateDataAccess
    {
        DataAcces dataAcces;
        public UpdateDataAccess()
        {
            this.dataAcces = new DataAcces();
        }

        public int UpdateNotes(Note note)
        {
            string query = "UPDATE Notes SET Note='" + note.Note1 + "',Important='" + note.Important + "',Date='" + note.Date + "'";
            int result = this.dataAcces.ExecuteQuery(query);
            return result;
        }

    }
}
