using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazaar.Models
{
    public class Department : Model
    {
        protected long id { get;private set; }
        protected string Name { get;private set; }
        protected List<User> Workers { get;private set; }

        public Department(string name)
        {
            this.Workers = new List<User>();
            this.Name = name;
        }

        public Department(string name, List<User> workers)
        {
            this.Workers = new List<User>();
            this.Name = name;
            this.Workers = workers;
        }

        public override void Insert()
        {
            dbConnection.OpenConnection();
            string query = "INSERT INTO departments(name) VALUES(@name)";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                var nameParam = cmd.Parameters.AddWithValue("@name", Name);

                cmd.ExecuteNonQuery();
                this.id = cmd.LastInsertedId;
            }

            dbConnection.CloseConnection();
        }

        public override void Delete()
        {
            dbConnection.OpenConnection();
            string query = $"DELETE FROM departments WHERE id = {id}";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.ExecuteNonQuery();
            }

            dbConnection.CloseConnection();
        }

        public override void Update<T>(T obj)
        {
            throw new NotImplementedException();
        }

        public void AssignWorkersToDepartment( List<User> workers)
        {
            dbConnection.OpenConnection();
            foreach (var item in workers)
            {
               //string query = $"UPDATE workers SET Department_Id = {id} WHERE id = {workers.id}";
               //using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
               //{
               //    cmd.ExecuteNonQuery();
               //}
            }
        }

        public int GetDepartmentId()
        {
            int result = 0;
            string query = $"SELECT id FROM departments WHERE Name = @Name";

            dbConnection.OpenConnection();

            // MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection);
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                var nameParam = cmd.Parameters.AddWithValue("@Name", Name);

                cmd.ExecuteNonQuery();
                this.id = cmd.LastInsertedId;

                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    result = Convert.ToInt32(dataReader["id"]);

                }
            }

            

            dbConnection.CloseConnection();

            return result;
        }
    }
}
