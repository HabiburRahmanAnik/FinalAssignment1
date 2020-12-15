using FinalTermAssignment.DataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermAssignment.Diary_Logic_Layer
{
    class DeleteService
    {
        DeleteEventDataAccess deleteEventDataAccess;
        public DeleteService()
        {
            this.deleteEventDataAccess = new DeleteEventDataAccess();
        }

        public int DeleteNotes(int id)
        {
            return this.deleteEventDataAccess.DeleteNote(id);
        }
    }
}
