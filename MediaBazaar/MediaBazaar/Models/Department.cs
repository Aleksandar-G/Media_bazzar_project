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
        public long Id { get; private set; }
        protected string Name { get; private set; }
        protected List<Worker> Workers { get; private set; }

        public Department(string name)
        {
            this.Workers = new List<Worker>();
            this.Name = name;
        }

        public Department(long id, string name)
        {
            this.Id = id;
            this.Workers = new List<Worker>();
            this.Name = name;
        }

        public Department(string name, List<Worker> workers)
        {
            this.Workers = new List<Worker>();
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
                this.Id = cmd.LastInsertedId;
            }

            dbConnection.CloseConnection();
        }

        public override void Delete()
        {
            dbConnection.OpenConnection();
            string query = $"DELETE FROM departments WHERE id = {Id}";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.ExecuteNonQuery();
            }

            dbConnection.CloseConnection();
        }


        public override void Update(Model obj)
        {
            throw new NotImplementedException();
        }

        public long GetDepartmentId()
        {
            long result = 0;
            string query = $"SELECT id FROM departments WHERE Name = @Name";

            dbConnection.OpenConnection();

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                var nameParam = cmd.Parameters.AddWithValue("@Name", Name);


                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    result = Convert.ToInt64(dataReader["id"]);
                }
            }

            dbConnection.CloseConnection();
            return result;
        }

        public static Department GetByName(string name)
        {
            Department department;
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();

            string query = $"SELECT id FROM departments WHERE Name = @Name";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                var nameParam = cmd.Parameters.AddWithValue("@Name", name);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    long id = Convert.ToInt64(dataReader["id"]);
                    department = new Department(id, name);

  
                    return department;
                }
            }

            dbConnection.CloseConnection();
            return null;
        }

        public static List<Department> GetAll()
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            List<Department> departments = new List<Department>();
            string query = "SELECT * FROM departments";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader["id"]);
                    string name = reader["name"].ToString();

                    departments.Add(new Department(id, name));
                }
            }

            dbConnection.CloseConnection();
            return departments;
        }

        public static List<string> GetNames()
        {
            List<string> departmentNames = new List<string>();
            List<Department> departments = Department.GetAll();

            departments.ForEach(x => departmentNames.Add(x.Name));
            return departmentNames;
        }

        public static long GetTheNewestDepartmentId()
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            long Id = 0;
            string query = "SELECT Id FROM `departments` ORDER BY ID DESC LIMIT 1";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                     Id = Convert.ToInt64(reader["id"]);
                }
            }

            dbConnection.CloseConnection();
            return Id;
        }
    }
}
