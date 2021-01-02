using FinalTermAssignment.DataAcces;
using FinalTermAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermAssignment.Diary_Logic_Layer
{
    class SignUpService
    {
        SignUpDataAccess signUpDataAccess;
        public SignUpService()
        {
            this.signUpDataAccess = new SignUpDataAccess();
        }
        public int InsertUser(string name,string userName,string password,string email,string dateOfBirth,string gender)
        {
            User user = new User()
            {
                Name = name,
                UserName = userName,
                Password = password,
                Email = email,
                DateOfBirth=dateOfBirth,
                Gender=gender
            };
            return this.signUpDataAccess.InsertUser(user);
        }
    }
}
