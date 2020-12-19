using FinalTermAssignment.DataAcces;
using FinalTermAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermAssignment.Diary_Logic_Layer
{
    class ModifyService
    {
        ModifyEventDataAccess modifyEventDataAccess;
        public ModifyService()
        {
            this.modifyEventDataAccess = new ModifyEventDataAccess();
        }
        public int ModifyNotes(int eventId,string title,string writetab,string date,string priority)
        {
            Event note = new Event()
            {      
                EventId=eventId,
                Title = title,
                WriteTab = writetab,
                Priority = priority,
                Date = date
            };
            return this.modifyEventDataAccess.ModofyNotes(note);
        }
    }
}
