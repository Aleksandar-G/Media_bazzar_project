using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

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
        private decimal salary;
        private DateTime birthday;
        private DateTime startDate;
        private DateTime endDate;

        private HttpClient client = new HttpClient();
        private const string REGISTER_URL = "http://localhost:8000/api/register";

        public long Id { get { return this.id; } }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        protected string Password { get => password; }
        public string Role { get => role; set => role = value; }
        public decimal Salary { get => salary; set => salary = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }

        public User(string name,
                    string email,
                    string phone,
                    string role,
                    decimal salary,
                    DateTime birthday,
                    DateTime startDate,
                    DateTime endDate) : base()
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.role = role;
            this.salary = salary;
            this.birthday = birthday;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public User(User anotherUser) : base()
        {
            this.id = anotherUser.Id;
            this.name = anotherUser.name;
            this.email = anotherUser.email;
            this.password = anotherUser.password;
            this.phone = anotherUser.phone;
            this.role = anotherUser.role;
            this.salary = anotherUser.salary;
            this.birthday = anotherUser.birthday;
            this.startDate = anotherUser.startDate;
            this.endDate = anotherUser.endDate;
        }

        public User(long id,
                    string name,
                    string email,
                    string password,
                    string phone,
                    string role,
                    decimal salary,
                    DateTime birthday,
                    DateTime startDate,
                    DateTime endDate) : base()
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.phone = phone;
            this.role = role;
            this.salary = salary;
            this.birthday = birthday;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public override void Insert()
        {
            this.password = GeneratePassword(8);

            var values = new Dictionary<string, string>
            {
                { "name", this.name },
                { "email", this.email },
                { "password", this.password },
                { "phone", this.phone },
                { "role", this.role },
                { "salary", this.salary.ToString() },
                { "birthday", this.birthday.ToString("yyyy-MM-dd") },
                { "start_date", this.startDate.ToString("yyyy-MM-dd") },
                { "created_at", DateTime.Now.ToString("yyyy-MM-dd") },
                { "updated_at", DateTime.Now.ToString("yyyy-MM-dd") }
            };

            var content = new FormUrlEncodedContent(values);
            var response = client.PostAsync(REGISTER_URL, content).Result;
            var responseString = response.Content.ReadAsStringAsync().Result;
            var obj = JObject.Parse(JObject.Parse(responseString).GetValue("success").ToString());
            this.id = Convert.ToInt64(obj.GetValue("id"));
        }

        public override void Delete()
        {
            dbConnection.OpenConnection();
            string query = $"UPDATE users SET end_date='{endDate.ToString("yyyy-MM-dd")}', updated_at=NOW() where id = {id}";

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
            string query = "SELECT * FROM users WHERE end_date IS NULL";
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
                    decimal salary = Convert.ToDecimal(reader["salary"].ToString());
                    DateTime birthday = DateTime.Parse(reader["birthday"].ToString());
                    DateTime startDate = DateTime.Parse(reader["start_date"].ToString());
                    DateTime.TryParse(reader["end_date"].ToString(), out DateTime endDate);

                    users.Add(new User(id, name, email, password, phone, role, salary, birthday, startDate, endDate));
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
            string query = $"SELECT * FROM users WHERE id = {id} AND end_date IS NULL LIMIT 1";
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
                    decimal salary = Convert.ToDecimal(reader["salary"].ToString());
                    DateTime birthday = DateTime.Parse(reader["birthday"].ToString());
                    DateTime startDate = DateTime.Parse(reader["start_date"].ToString());
                    DateTime.TryParse(reader["end_date"].ToString(), out DateTime endDate);

                    user = new User(id, name, email, password, phone, role, salary, birthday, startDate, endDate);

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
            string query = "SELECT * FROM users WHERE email = @email AND end_date IS NULL LIMIT 1";
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
                    decimal salary = Convert.ToDecimal(reader["salary"].ToString());
                    DateTime birthday = DateTime.Parse(reader["birthday"].ToString());
                    DateTime.TryParse(reader["start_date"].ToString(), out DateTime startDate);
                    DateTime.TryParse(reader["end_date"].ToString(), out DateTime endDate);


                    user = new User(userId, userName, email, userPassword, phone, role, salary, birthday, startDate, endDate);

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

            string query = $@"UPDATE users 
                              SET name = @name, phone = @phone, salary = @salary, birthday = @birthday 
                              WHERE email = @email AND end_date IS NULL";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@name", user.name);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@phone", user.phone);
                cmd.Parameters.AddWithValue("@salary", user.Salary);
                cmd.Parameters.AddWithValue("@birthday", user.Birthday);

                cmd.ExecuteNonQuery();
            }

            dbConnection.CloseConnection();
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
