using MySql.Data.MySqlClient;
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

        public Manager(string name, string email, string phone, decimal salary, DateTime birthday) 
            : base(name, email, phone, "Manager", salary, birthday)
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
            this.userId = base.Id;

            dbConnection.OpenConnection();
            string query = "INSERT INTO managers(user_id) VALUES(@userId)";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@userId", this.userId);

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

        public static Manager GetByUserId(long userId)
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            Manager manager;
            string query = $"SELECT * FROM managers WHERE user_id = @userId";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader["id"]);
                    User user = User.GetById(Convert.ToInt64(reader["user_id"]));

                    manager = new Manager(id, user);

                    dbConnection.CloseConnection();
                    return manager;
                }
            }

            dbConnection.CloseConnection();
            return null;
        }

    }
}
