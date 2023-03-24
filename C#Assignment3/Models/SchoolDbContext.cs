using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C_Assignment3.Models
{
    public class SchoolDbContext
    {
        private static string User { get { return "root"; } }
        private static string Password { get { return "root"; } }
        private static string Database { get { return "schooldb"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }


        protected static string ConnectionString
        {
            get
            {
                // Convert Zero Datetime is a setting that will interpret a 0000-00-00 as null
                // This makes it easier for C# to convert to a proper DateTime type
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password
                    + "; convert zero datetime = True";
            }
        }

        public MySqlConnection AccessDatabase()
        {

            return new MySqlConnection(ConnectionString);
        }
    }
}