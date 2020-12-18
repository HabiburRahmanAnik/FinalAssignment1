using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermAssignment.DataAcces
{
    class DeleteEventDataAccess
    {
        DataAcces dataAcces;

        public DeleteEventDataAccess()
        {
            this.dataAcces = new DataAcces();
        }

        public int DeleteNote(int id)
        {
            string query = "DELETE FROM Events WHERE [EventId]=" + id;
            int result =this.dataAcces.ExecuteQuery(query);
            return result;
        }
    }
}
