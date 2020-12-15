using FinalTermAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermAssignment.DataAcces
{
    class AddEventDataAccess
    {
        DataAcces dataAcces;
        public AddEventDataAccess()
        {
            this.dataAcces = new DataAcces();
        }

        public int Add(Note note)
        {
            string query = "INSERT INTO Notes(Note,Important,Date) VALUES('" + note.Note1 + "','" + note.Important + "','" + note.Date + "')";
            int result = this.dataAcces.ExecuteQuery(query);
            return result;
        }
    }
}
