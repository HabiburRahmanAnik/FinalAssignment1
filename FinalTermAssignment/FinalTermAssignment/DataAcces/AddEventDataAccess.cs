using FinalTermAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public int Add(Event note)
        {
            string query = "INSERT INTO Events(Title,WriteTab,Priority,Date,Id) VALUES('" + note.Title + "','" + note.Note1 + "','" + note.Priority + "','"+note.Date+"') WHERE";
            int result = this.dataAcces.ExecuteQuery(query);
            return result;
        }
        public List<Event> GetAllEvent(string username)
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
                note.Title = reader["Title"].ToString();
                note.Note1 = reader["WriteTab"].ToString();
                note.Priority = reader["Priority"].ToString();
                note.Date = reader["Date"].ToString();
                list.Add(note);
            }
            return list;
        }
    }
}
