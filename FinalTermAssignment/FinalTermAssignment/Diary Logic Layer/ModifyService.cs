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
        public int ModifyNotes(int id,string note1,string date,string important)
        {
            Event note = new Event()
            {
                Id = id,
                Note1 = note1,
                Priority = important,
                Date = date
            };
            return this.modifyEventDataAccess.ModofyNotes(note);
        }
    }
}
