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
        public string Name { get; private set; }
        public long SupervisorId { get; private set; }
        protected List<Worker> Workers { get; private set; }

        public Department(string name)
        {
            this.Workers = new List<Worker>();
            this.Name = name;
        }

        public Department(long id, string name, long supervisorId)
        {
            this.Id = id;
            this.Workers = new List<Worker>();
            this.Name = name;
            this.SupervisorId = supervisorId;
        }

        public Department(string name, List<Worker> workers, long supervisorId)
        {
            this.Workers = new List<Worker>(workers);
            this.Name = name;
            this.Workers = workers;
            this.SupervisorId = supervisorId;
        }

        public Department(Department otherDepartment)
        {
            this.Id = otherDepartment.Id;
            this.Workers = new List<Worker>(otherDepartment.Workers);
            this.Name = otherDepartment.Name;
            this.SupervisorId = otherDepartment.SupervisorId;
        }


        public override void Insert()
        {
            dbConnection.OpenConnection();
            string query = "INSERT INTO departments(name, created_at, updated_at) VALUES(@name, NOW(), NOW())";

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


        public override void Update(Model updatedDepartment)
        {
            Department department = (Department)updatedDepartment;
            dbConnection.OpenConnection();

            string query = @"UPDATE departments SET name = @name, supervisor_id = @supervisor_id, updated_at = NOW() WHERE id = @id";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@name", department.Name);
                if (department.SupervisorId == 0)
                {
                    cmd.Parameters.AddWithValue("@supervisor_id", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@supervisor_id", department.SupervisorId);
                }
                cmd.Parameters.AddWithValue("@id", Id);

                cmd.ExecuteNonQuery();
            }

            dbConnection.CloseConnection();
        }

        public static Department GetById(long id)
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            string query = $"SELECT * FROM departments WHERE id = @id LIMIT 1";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    int colIndex = reader.GetOrdinal("supervisor_id");
                    long supervisorId = 0;
                    if (!reader.IsDBNull(colIndex))
                    {
                        supervisorId = Convert.ToInt64(reader["supervisor_id"]);
                    }
                    dbConnection.CloseConnection();
                    return new Department(id, name, supervisorId);
                }
            }

            dbConnection.CloseConnection();
            return null;
        }

        public static Department GetByName(string name)
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();

            string query = $"SELECT * FROM departments WHERE name = @name";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                var nameParam = cmd.Parameters.AddWithValue("@name", name);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    long id = Convert.ToInt64(dataReader["id"]);
                    long supervisorId = 0;
                    if (dataReader["supervisor_id"] != DBNull.Value)
                    {
                        supervisorId = Convert.ToInt64(dataReader["supervisor_id"]);
                    }

                    return new Department(id, name, supervisorId);
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
                    long supervisorId = 0;
                    int colIndex = reader.GetOrdinal("supervisor_id");
                    if (!reader.IsDBNull(colIndex))
                    {
                        supervisorId = Convert.ToInt64(reader["supervisor_id"]);
                    }

                    departments.Add(new Department(id, name, supervisorId));
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
            string query = "SELECT id FROM `departments` ORDER BY ID DESC LIMIT 1";
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
