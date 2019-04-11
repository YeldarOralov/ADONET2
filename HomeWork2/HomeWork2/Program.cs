using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["appContext"].ConnectionString))
            {
                connection.Open();
                string commandText = "create table [Group] (id int NOT NULL Primary key Identity(1,1), Name nvarchar(MAX) NOT NULL)";
                var command = new SqlCommand(commandText, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
