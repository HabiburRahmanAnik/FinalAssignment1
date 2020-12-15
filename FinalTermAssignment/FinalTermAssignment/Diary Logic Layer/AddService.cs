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
        public int Add(string note,string important,string date)
        {
            Note note1 = new Note()
            {
                Note1 = note,
                Important = important,
                Date = date           
            };
            return this.addEventDataAccess.Add(note1);
        }
    }
}
