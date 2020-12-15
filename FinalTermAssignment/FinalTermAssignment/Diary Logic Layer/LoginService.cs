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

        public List<User> Login(string username, string password)
        {
            User user = new User()
            {
                UserName=username,
                Password=password
            };

            return this.loginDataAcces.Login(user);
        }
    }
}
