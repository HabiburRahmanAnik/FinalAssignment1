using FinalTermAssignment.DataAcces;
using FinalTermAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermAssignment.Diary_Logic_Layer
{
    class LoginService
    {
        LoginDataAcces loginDataAcces;
        public LoginService()
        {
            this.loginDataAcces = new LoginDataAcces();
        }

        public bool Login(string username, string password)
        {
           return this.loginDataAcces.Login(username,password);
        }
    }
}
