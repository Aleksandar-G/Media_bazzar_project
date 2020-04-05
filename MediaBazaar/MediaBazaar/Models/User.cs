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
        private string name;
        private string email;
        private string phone;
        private string password;
        private string role;

        public long Id { get { return this.id; } }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        protected string Password { get => password; }
        public string Role { get => role; set => role = value; }

        public User(string name, string email, string phone, string role) : base()
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.role = role;
        }

        public User(User anotherUser) : base()
        {
            this.id = anotherUser.Id;
            this.name = anotherUser.name;
            this.email = anotherUser.email;
            this.password = anotherUser.password;
            this.phone = anotherUser.phone;
            this.role = anotherUser.role;
        }

        public User(long id, string name, string email, string password, string phone, string role) : base()
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.phone = phone;
            this.role = role;
        }

        public override void Insert()
        {
            this.password = GeneratePassword(8);

            dbConnection.OpenConnection();
            string query = "INSERT INTO users(name, email, password, phone, role) VALUES(@name, @email, @password, @phone, @role)";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                string password = BCrypt.Net.BCrypt.HashPassword(this.password);
                password.Replace("$2a$", "$2y$");

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@role", role);

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
                    string phone = reader["phone"].ToString();
                    string role = reader["role"].ToString();

                    users.Add(new User(id, name, email, password, phone, role));
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
                    string phone = reader["phone"].ToString();
                    string role = reader["role"].ToString();

                    user = new User(id, name, email, password, phone, role);

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
                    string phone = reader["phone"].ToString();
                    string role = reader["role"].ToString();

                    user = new User(userId, userName, userEmail, userPassword, phone, role);

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

            string query = $"UPDATE users SET name = @name, email = @email, phone = @phone, role = @role WHERE id = {user.Id}";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@name", user.name);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@phone", user.phone);
                cmd.Parameters.AddWithValue("@role", user.role);

                cmd.ExecuteNonQuery();
            }

            dbConnection.CloseConnection();
        }

        private void SendPassword()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.mailgun.org");

            mail.From = new MailAddress("no-reply@mediabazaar.xyz");
            mail.To.Add(this.email);
            mail.Subject = "Account created";
            mail.Body = $"Hello, {this.name}! You have registered to our application. This is your password: {this.password}";

            SmtpServer.Port = 587;
            SmtpServer.Credentials =
                new System.Net.NetworkCredential("postmaster@mediabazaar.xyz", "27404e89798aa79aa8b6dff6123a92f1-9a235412-fb09f04b");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);

        }
        private static string GeneratePassword(int length)
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
