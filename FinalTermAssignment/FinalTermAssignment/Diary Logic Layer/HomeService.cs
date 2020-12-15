using FinalTermAssignment.DataAcces;
using FinalTermAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermAssignment.Diary_Logic_Layer
{
    class HomeService
    {
        HomeDataAccess homeDataAccess;

        public HomeService()
        {
            this.homeDataAccess = new HomeDataAccess();
        }

        public List<Note> GetAllNote()
        {
            return this.homeDataAccess.GetAllNote();
        }
    }
}
