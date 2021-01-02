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

        public int Add(Event events)
        {
            string query = "INSERT INTO Event2(Title,WriteTab,Priority,Date,UserId) VALUES('" + events.Title + "','" + events.WriteTab + "','" + events.Priority + "','" + events.Date + "','" + events.Id + "')";
            dataAcces = new DataAcces();
            int result = this.dataAcces.ExecuteQuery(query);
            return result;
        }
        public List<Event> GetAllEvent(string username)
        {
            string query = "SELECT * FROM Users WHERE Username='" + username + "'";
            SqlDataReader reader = this.dataAcces.GetAll(query);
            reader.Read();
            int id = (int)reader["UserId"];
            string query1 = "SELECT * FROM Event2 WHERE UserId=" + id;
            dataAcces = new DataAcces();
            reader = this.dataAcces.GetAll(query1);
            List<Event> list = new List<Event>();
            while (reader.Read())
            {
                Event note = new Event();
                note.EventId = (int)reader["EventId"];
                note.Title = reader["Title"].ToString();
                note.WriteTab = reader["WriteTab"].ToString();
                note.Priority = reader["Priority"].ToString();
                note.Date = reader["Date"].ToString();
                note.Id = (int)reader["UserId"];
                list.Add(note);
            }
            return list;
        }
        public int GetUserId(string username)
        {
            string query = "SELECT * FROM Users WHERE Username='" + username + "'";
            SqlDataReader reader = this.dataAcces.GetAll(query);
            reader.Read();
            return (int)reader["UserId"];

        }
    }
}
