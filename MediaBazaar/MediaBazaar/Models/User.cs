using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Models
{
    public class User : Model
    {
        protected long id;
        protected string name;
        protected string email;
        protected string password;

        public User(string name, string email, string password): base()
        {
            this.name = name;
            this.email = email;
            this.password = BCrypt.Net.BCrypt.HashPassword(password);
        }

        public User(int id, string name, string email, string password) : base()
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
        }

        public override void Insert()
        {
            dbConnection.OpenConnection();
            string query = "INSERT INTO users(name, email, password) VALUES(@name, @email, @password)";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                var nameParam = cmd.Parameters.AddWithValue("@name", name);
                var emailParam = cmd.Parameters.AddWithValue("@email", email);
                var passwordParam = cmd.Parameters.AddWithValue("@password", password);

                cmd.ExecuteNonQuery();
                this.id = cmd.LastInsertedId;
            }

            dbConnection.CloseConnection();
        }

        public override void Delete()
        {
            dbConnection.OpenConnection();
            string query = $"DELETE FROM users where id = {id}";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.ExecuteNonQuery();
            }

            dbConnection.CloseConnection();
        }

        public static List<User> GetAll()
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            List<User> users = new List<User>();
            string query = "SELECT * FROM users";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                MySqlDataReader rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    int id = Convert.ToInt32(rdr["id"]);
                    string name = rdr["name"].ToString();
                    string email = rdr["email"].ToString();
                    string password = rdr["password"].ToString();

                    users.Add(new User(id, name, email, password));
                }
            }

            dbConnection.CloseConnection();
            return users;
        }

        public static User GetById(int id)
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            User user;
            string query = $"SELECT * FROM users WHERE id = {id}";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

                int userId = Convert.ToInt32(rdr["id"]);
                string name = rdr["name"].ToString();
                string email = rdr["email"].ToString();
                string password = rdr["password"].ToString();

                user = new User(id, name, email, password);
            }

            dbConnection.CloseConnection();
            return user;
        }

        public override void Update<User>(User newUser)
        {
            throw new NotImplementedException();
        }
    }
}
