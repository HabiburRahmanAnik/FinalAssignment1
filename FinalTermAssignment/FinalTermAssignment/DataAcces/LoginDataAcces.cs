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

        public List<User> Login(User user)
        {
            string query = "SELECT * FROM User3 WHERE Username='" + user.UserName + "' and Password='" + user.Password + "'";
            SqlDataReader reader = this.dataAcces.GetAll(query);
            List<User> users = new List<User>();

            while(reader.Read())
            {
                user.Id = (int)reader["Id"];
                user.UserName = reader["UserName"].ToString();
                user.Password = reader["Password"].ToString();
                users.Add(user);
            }
            return users;
        }
    }
}
