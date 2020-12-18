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
        public List<Event> GetAllNote(string username)
        {
            string query = "SELECT * FROM User3 WHERE Username='" + username + "'";           
            SqlDataReader reader = this.dataAcces.GetAll(query);
            reader.Read();
            int id = (int)reader["Id"];
            string query1 = "SELECT * FROM Events WHERE Id=" + id;
            dataAcces = new DataAcces();
            reader = this.dataAcces.GetAll(query1);
            List<Event> list = new List<Event>();
            while (reader.Read())
            {
                Event note = new Event();
                note.EventId = (int)reader["EventId"];
                note.Title = reader["Title"].ToString();
                note.Date = reader["Date"].ToString();
                list.Add(note);
            }
            return list;
        }
    }
}
