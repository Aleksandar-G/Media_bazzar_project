using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

        public long Id { get { return this.id; } }

        public User(string name, string email) : base()
        {
            this.name = name;
            this.email = email;
        }

        public User(long id, string name, string email, string password) : base()
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
        }

        public override void Insert()
        {
            this.password = GeneratePassword(8);

            dbConnection.OpenConnection();
            string query = "INSERT INTO users(name, email, password) VALUES(@name, @email, @password)";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                var nameParam = cmd.Parameters.AddWithValue("@name", name);
                var emailParam = cmd.Parameters.AddWithValue("@email", email);
                var passwordParam = cmd.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword(this.password));

                cmd.ExecuteNonQuery();
                this.id = cmd.LastInsertedId;
                this.SendPassword();
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
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader["id"]);
                    string name = reader["name"].ToString();
                    string email = reader["email"].ToString();
                    string password = reader["password"].ToString();

                    users.Add(new User(id, name, email, password));
                }
            }

            dbConnection.CloseConnection();
            return users;
        }

        public static User GetById(long id)
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            User user;
            string query = $"SELECT * FROM users WHERE id = {id}";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int userId = Convert.ToInt32(reader["id"]);
                    string name = reader["name"].ToString();
                    string email = reader["email"].ToString();
                    string password = reader["password"].ToString();

                    user = new User(id, name, email, password);

                    dbConnection.CloseConnection();
                    return user;
                }
            }

            dbConnection.CloseConnection();
            return null;
        }

        public static User GetByEmail(string email)
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            User user;
            string query = "SELECT * FROM users WHERE email = @email";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@email", email);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int userId = Convert.ToInt32(reader["id"]);
                    string userName = reader["name"].ToString();
                    string userEmail = reader["email"].ToString();
                    string userPassword = reader["password"].ToString();

                    user = new User(userId, userName, userEmail, userPassword);

                    dbConnection.CloseConnection();
                    return user;
                }
            }

            dbConnection.CloseConnection();
            return null;
        }

        public override void Update(Model newUser)
        {
            User user = (User)newUser;
            dbConnection.OpenConnection();

            string query = $"UPDATE users SET name=@name, email=@email WHERE id = {user.Id}";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                var nameParam = cmd.Parameters.AddWithValue("@name", user.name);
                var emailParam = cmd.Parameters.AddWithValue("@email", user.email);

                cmd.ExecuteNonQuery();
            }

            dbConnection.CloseConnection();
        }

        public void SendPassword()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.mailgun.org");

            mail.From = new MailAddress("admin@mediabazaar.com");
            mail.To.Add(this.email);
            mail.Subject = "Account created";
            mail.Body = $"Hello, {this.name}! You have registered to our application. This is your password: {this.password}";

            SmtpServer.Port = 587;
            SmtpServer.Credentials =
                new System.Net.NetworkCredential("postmaster@sandbox9bc004f63231411796e06428ffa17f67.mailgun.org", "1bcb7c279e414803ab1fb01ac2a7b883-9a235412-647e0595");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);

        }
        public static string GeneratePassword(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static bool Authenticate(string email, string password)
        {
            User user = GetByEmail(email);

            if (user == null)
            {
                return false;
            }

            return BCrypt.Net.BCrypt.Verify(password, user.password);
        }
    }
}
