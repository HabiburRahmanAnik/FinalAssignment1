using FinalTermAssignment.DataAcces;
using FinalTermAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermAssignment.Diary_Logic_Layer
{
    class AddService
    {
        AddEventDataAccess addEventDataAccess;

        public AddService()
        {
            this.addEventDataAccess = new AddEventDataAccess();
        }
        public int Add(string title,string note,string priority,string date, int id)
        {
            //int userId = addEventDataAccess.GetUserId(username);
            Event events = new Event()
            {
                Title=title,
                WriteTab = note,
                Priority = priority,
                Date = date,
                Id = id           
            };
            return this.addEventDataAccess.Add(events);
        }
        public List<Event> GetAllEvent(string username)
        {
            return this.addEventDataAccess.GetAllEvent(username);
        }
    }
}
