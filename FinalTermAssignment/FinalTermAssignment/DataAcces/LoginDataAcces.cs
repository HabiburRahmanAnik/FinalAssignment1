using FinalTermAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermAssignment.DataAcces
{
    class LoginDataAcces
    {
        DataAcces dataAcces;

        public LoginDataAcces()
        {
            this.dataAcces = new DataAcces();
        }

        public bool Login(string username,string password)
        {
            string query = "SELECT * FROM User3 WHERE Username='" + username + "' and Password='" + password + "'";
            SqlDataReader reader = this.dataAcces.GetAll(query);
            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
