using FinalTermAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermAssignment.DataAcces
{
    class HomeDataAccess
    {
        DataAcces dataAcces;
        public HomeDataAccess()
        {
            this.dataAcces = new DataAcces();

        }
        public List<Note> GetAllNote()
        {
            string query = "SELECT * FROM Notes";
            
            SqlDataReader reader = this.dataAcces.GetAll(query);

            List<Note> list = new List<Note>();
            while (reader.Read())
            {
                Note note = new Note();
                note.Id = (int)reader["Id"];
                note.Note1 = reader["Note"].ToString();
                note.Important = reader["Important"].ToString();
                note.Date = reader["Date"].ToString();
                list.Add(note);
            }
            return list;
        }
    }
}
