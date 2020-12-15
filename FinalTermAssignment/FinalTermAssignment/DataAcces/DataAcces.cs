
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermAssignment.DataAcces
{
    class DataAcces:IDisposable
    {
        SqlConnection connection;
        SqlCommand command;

        public DataAcces()
        {
            this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OOP2[E]"].ConnectionString);
            this.connection.Open();
        }

        public SqlDataReader GetAll(string query)
        {
            this.command = new SqlCommand(query, this.connection);
            SqlDataReader reader = this.command.ExecuteReader();
            return reader;
        }
        public int ExecuteQuery(string query)
        {
            this.command = new SqlCommand(query, this.connection);
            int result = this.command.ExecuteNonQuery();
            return result;
        }

        public void Dispose()
        {
            this.connection.Close();
        }
    }
}
