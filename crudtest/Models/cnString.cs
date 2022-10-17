using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace crudtest.Models
{
    public class conString
    {
        public static string GetRDSConnectionString()
        {
            var appConfig = ConfigurationManager.AppSettings;

            string dbname = appConfig["userdb"];

            if (string.IsNullOrEmpty(dbname)) return null;

            string username = appConfig["admin"];
            string password = appConfig["Letmeinplz123"];
            string hostname = appConfig["userdb.cmmpo8fyxdya.us-east-1.rds.amazonaws.com"];
            string port = appConfig["3306"];

            return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }
    }
}