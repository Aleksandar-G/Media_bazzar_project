﻿using System;
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
        private string server = Environment.GetEnvironmentVariable("DB_HOST");//"127.0.0.1";//
        private string database = Environment.GetEnvironmentVariable("DB_DATABASE");//"laravel";//
        private string uid =Environment.GetEnvironmentVariable("DB_USERNAME");//"root";//
        private string password = Environment.GetEnvironmentVariable("DB_PASSWORD");//"root";//

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
