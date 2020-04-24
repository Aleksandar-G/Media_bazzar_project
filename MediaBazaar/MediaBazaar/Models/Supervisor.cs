using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Models
{
    class Supervisor : User
    {
        private long departmentId;
        private long userId;
        public long UserId { get => userId; }

        public long DepartmentId { get => departmentId; }

        public Supervisor(string name,
                          string email,
                          string phone,
                          long departmentId,
                          decimal salary,
                          DateTime birthday,
                          DateTime startDate,
                          DateTime endDate) : base(name, email, phone, "Supervisor", salary, birthday, startDate, endDate)
        {
            this.userId = base.id;
            this.departmentId = departmentId;
        }

        public Supervisor(long id, long departmentId, User user) : base(user)
        {
            this.id = id;
            this.departmentId = departmentId;
            this.userId = user.Id;
        }

        public override void Insert()
        {
            base.Insert();
            this.userId = base.Id;

            dbConnection.OpenConnection();
            string query = "INSERT INTO supervisors (user_id, department_id, created_at, updated_at) VALUES (@userId, @departmentId, NOW(), NOW())";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@userId", this.userId);
                cmd.Parameters.AddWithValue("@departmentId", this.departmentId);
                cmd.ExecuteNonQuery();
                this.id = cmd.LastInsertedId;
            }

            dbConnection.CloseConnection();

            Department department = Department.GetById(this.departmentId);
            Department updatedDepartment = new Department(department.Id, department.Name, this.Id);
            department.Update(updatedDepartment);
        }

        public void Delete(DateTime endDate)
        {
            base.EndDate = endDate;
            base.Delete();

            dbConnection.OpenConnection();
            string query = $"DELETE FROM supervisors where id = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@id", this.id);
                cmd.ExecuteNonQuery();
            }

            dbConnection.CloseConnection();
        }

        public override void Update(Model newSupervisor)
        {
            base.Update((User)newSupervisor);
            Supervisor supervisor = (Supervisor)newSupervisor;
            Department department = Department.GetById(this.departmentId);

            // Clear current refference to the supervisors table
            Department updatedDepartment = new Department(department.Id, department.Name, 0);
            department.Update(updatedDepartment);

            dbConnection.OpenConnection();

            string query = @"UPDATE supervisors SET department_id = @department_id, updated_at = NOW() WHERE id = @supervisor_id";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@department_id", supervisor.departmentId);
                cmd.Parameters.AddWithValue("@supervisor_id", supervisor.Id);

                cmd.ExecuteNonQuery();
            }

            dbConnection.CloseConnection();

            // Assign department to the current supervisor
            Department newDepartment = Department.GetById(supervisor.departmentId);
            updatedDepartment = new Department(supervisor.departmentId, newDepartment.Name, supervisor.Id);
            newDepartment.Update(updatedDepartment);
        }

        public static Supervisor GetByUserId(long userId)
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            Supervisor supervisor;
            string query = $"SELECT * FROM supervisors WHERE user_id = @userId";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader["id"]);
                    User user = User.GetById(Convert.ToInt64(reader["user_id"]));
                    long departmentId = Convert.ToInt64(reader["department_id"]);
                    supervisor = new Supervisor(id, departmentId, user);

                    dbConnection.CloseConnection();
                    return supervisor;
                }
            }

            dbConnection.CloseConnection();
            return null;
        }
    }
}
