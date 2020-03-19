﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Models
{
    class Manager : User
    {
        private new long id;
        private long userId;

        public Manager(string name, string email, string phone) : base(name, email, phone)
        {
            this.userId = base.Id;
        }

        public Manager(long id, User user) : base(user)
        {
            this.userId = base.Id;
            this.id = id;
        }

        public override void Insert()
        {
            base.Insert();

            dbConnection.OpenConnection();
            string query = "INSERT INTO managers(user_id) VALUES(@userId)";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@userId", base.Id);

                cmd.ExecuteNonQuery();
                this.id = cmd.LastInsertedId;
            }

            dbConnection.CloseConnection();
        }

        public override void Delete()
        {
            base.Delete();

            dbConnection.OpenConnection();
            string query = $"DELETE FROM managers where id = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@id", this.id);
                cmd.ExecuteNonQuery();
            }

            dbConnection.CloseConnection();
        }
    }
}
