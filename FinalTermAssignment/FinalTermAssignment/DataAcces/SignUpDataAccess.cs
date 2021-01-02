using FinalTermAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermAssignment.DataAcces
{
    class SignUpDataAccess
    {
        DataAcces dataAcces;
        public SignUpDataAccess()
        {
            this.dataAcces = new DataAcces();
        }

        public int InsertUser(User user)
        {
            string query = "INSERT INTO Users (Name,Username,Password,Email,DateOfBirth,Gender) VALUES('"+user.Name+"','"+user.UserName+"','"+user.Password+"','"+user.Email+"','"+user.DateOfBirth+"','"+user.Gender+"')";
            return this.dataAcces.ExecuteQuery(query);
        }
    }
}
