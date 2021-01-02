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

        public int ModofyNotes(Event note)
        {
            string query = "UPDATE Event2 SET [Title]='" + note.Title+ "',[WriteTab]='" + note.WriteTab + "',[Priority]='" + note.Priority + "',[Date]='" + note.Date + "' WHERE [EventId]=" + note.EventId;
            int result = this.dataAcces.ExecuteQuery(query);
            return result;
        }
    }
}
