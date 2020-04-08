using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Models
{
    class Administrator : User
    {
        private new long id;
        private long userId;

        public Administrator(string name, string email, string phone, decimal salary, DateTime birthday) 
            : base(name, email, phone, "Administrator", salary, birthday)
        {
            this.userId = base.Id;
        }

        public Administrator(long id, User user) : base(user)
        {
            this.userId = base.Id;
            this.id = id;
        }

        public override void Insert()
        {
            base.Insert();
            this.userId = base.Id;

            dbConnection.OpenConnection();
            string query = "INSERT INTO administrators(user_id, created_at, updated_at) VALUES(@userId, NOW(), NOW())";

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
            string query = $"DELETE FROM workers where id = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@id", this.id);
                cmd.ExecuteNonQuery();
            }

            dbConnection.CloseConnection();
        }

        public static Administrator GetByUserId(long userId)
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            Administrator administrator;
            string query = $"SELECT * FROM administrators WHERE user_id = @userId";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader["id"]);
                    User user = User.GetById(Convert.ToInt64(reader["user_id"]));

                    administrator = new Administrator(id, user);

                    dbConnection.CloseConnection();
                    return administrator;
                }
            }

            dbConnection.CloseConnection();
            return null;
        }
    }
}
