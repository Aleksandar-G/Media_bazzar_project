using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazaar
{
    public class DBconnection
    {
        public MySqlConnection connection;
        private string server = "studmysql01.fhict.local";
        //private string server = "localhost";
        private string database = "dbi425706";
        private string uid = "dbi425706";
        private string password = "12345678";
       // private string uid = "root";
        //private string password = "";

        //Constructor
        public DBconnection()
        {
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException)
            {               
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }

    }
}
