using crudtest.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace crudtest.Data
{
    internal class UserDao
    {

        private string connectionString = @"userdb.cmmpo8fyxdya.us-east-1.rds.amazonaws.com;Port=3306;Username=admin;Password=Letmeinplz123;Database=userdb;";
        public List<UserModel> Fetchall()
        {
            List<UserModel> returnList = new List<UserModel>();

            using (var connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * from dbo.Gadgets";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserModel Users = new UserModel();
                        Users.Id = reader.GetInt32(0);
                        Users.Name = reader.GetString(1);
                    }
                }

            }

            return returnList;
        }

    }
}