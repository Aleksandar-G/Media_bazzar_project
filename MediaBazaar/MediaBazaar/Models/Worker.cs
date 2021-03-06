﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Models
{
    public class Worker : User
    {
        private new long id;
        private long userId;
        private long departmentId;

        public new long Id { get => id; }
        public long UserId { get => userId; }
        public long DepartmentId { get => departmentId; }

        public Worker(string name, string email, string phone, long departmentId, decimal salary, DateTime birthday, DateTime startDate, DateTime endDate)
            : base(name, email, phone, "Worker", salary, birthday, startDate, endDate)
        {
            this.userId = base.id;
            this.departmentId = departmentId;
        }

        public Worker(long id, long departmentId, User user) : base(user)
        {
            this.id = id;
            this.userId = user.Id;
            this.departmentId = departmentId;
        }

        public override void Insert()
        {
            base.Insert();
            this.userId = base.Id;

            dbConnection.OpenConnection();
            string query = "INSERT INTO workers (user_id, department_id, created_at, updated_at) VALUES (@userId, @departmentId, NOW(), NOW())";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@userId", this.userId);
                cmd.Parameters.AddWithValue("@departmentId", this.departmentId);
                cmd.ExecuteNonQuery();
                this.id = cmd.LastInsertedId;
            }

            dbConnection.CloseConnection();
        }

        public void Delete(DateTime endDate)
        {
            base.EndDate = endDate;
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

        public new static List<Worker> GetAll()
        {
            DBconnection dbConnection = new DBconnection();
            List<Worker> workers = new List<Worker>();

            dbConnection.OpenConnection();

            string query = "SELECT * FROM workers";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader["id"]);
                    long userId = Convert.ToInt64(reader["user_id"]);
                    long departmentId = Convert.ToInt64(reader["department_id"]);
                    //Shift workshift = (Shift)Enum.Parse(typeof(Shift), reader["workshift"].ToString());

                    User user = User.GetById(userId);

                    workers.Add(new Worker(id, departmentId, user));
                }
            }

            dbConnection.CloseConnection();
            return workers;
        }

        public new static Worker GetById(long id)
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            Worker worker;
            string query = $"SELECT * FROM workers WHERE id = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = User.GetById(Convert.ToInt64(reader["user_id"]));
                    long departmentId = Convert.ToInt64(reader["department_id"]);
                    //Shift workshift = (Shift)Enum.Parse(typeof(Shift), reader["workshift"].ToString());

                    worker = new Worker(id, departmentId, user);

                    dbConnection.CloseConnection();
                    return worker;
                }
            }

            dbConnection.CloseConnection();
            return null;
        }

        public static Worker GetByUserId(long userId)
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            Worker worker;
            string query = $"SELECT * FROM workers WHERE user_id = @userId";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader["id"]);
                    User user = User.GetById(Convert.ToInt64(reader["user_id"]));
                    long departmentId = Convert.ToInt64(reader["department_id"]);

                    worker = new Worker(id, departmentId, user);

                    dbConnection.CloseConnection();
                    return worker;
                }
            }

            dbConnection.CloseConnection();
            return null;
        }

        public override void Update(Model newWorker)
        {
            base.Update((User)newWorker);
            Worker worker = (Worker)newWorker;
            dbConnection.OpenConnection();

            string query = @"UPDATE workers SET user_id = @user_id, department_id = @department_id WHERE id = @workerId";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@user_id", worker.userId);
                cmd.Parameters.AddWithValue("@department_id", worker.departmentId);
                cmd.Parameters.AddWithValue("@workerId", worker.Id);

                cmd.ExecuteNonQuery();
            }

            dbConnection.CloseConnection();
        }

        public static Dictionary<long, string> GetAllWorkersWithoutDepartment()
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            //List<User> workers = new List<User>();
            Dictionary<long, string> workers = new Dictionary<long, string>();
            string query =
            @"
                SELECT u.Name, u.Id,u.Email, u.Password, u.Phone FROM users as u
                INNER JOIN workers as w 
                ON u.Id = w.user_id 
                WHERE w.Department_id IS NULL
            ";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader["Id"]);
                    string name = reader["Name"].ToString();
                    workers.Add(id, name);
                }
                dbConnection.CloseConnection();
                return workers;
            }
        }

        public static Dictionary<long, string> GetAllWorkersWithDepartments()
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();

            Dictionary<long, string> workers = new Dictionary<long, string>();
            string query =
            @"
                SELECT u.Name, u.Id,u.Email, u.Password, u.Phone FROM users as u
                INNER JOIN workers as w 
                ON u.Id = w.user_id
                WHERE u.end_date IS NULL
            ";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader["Id"]);
                    string name = reader["Name"].ToString();
                    workers.Add(id, name);
                }
                dbConnection.CloseConnection();
                return workers;
            }
        }

        public static Dictionary<string, int> GetWorkersByDepartment()
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            Dictionary<string, int> result = new Dictionary<string, int>();
            string query =
            @"
                SELECT COUNT(*) as num, d.Name as name FROM workers 
                INNER JOIN departments as d 
                ON workers.department_id = d.Id 
                GROUP BY d.Name;
            ";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader["name"].ToString(), Convert.ToInt32(reader["num"]));
                }
            }

            dbConnection.CloseConnection();
            return result;
        }

        public static void AssignWorkerToDepartment(long id, long DepartmentId)
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();

            string query = $"UPDATE workers SET Department_id = {DepartmentId} WHERE user_id = {id}";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.ExecuteNonQuery();
            }
            dbConnection.CloseConnection();
        }

        public static Shift GetWorkshiftByName(string val)
        {
            switch (val)
            {
                case "Morning":
                    return Shift.Morning;
                case "Afternoon":
                    return Shift.Afternoon;
                case "Evening":
                    return Shift.Evening;
                default:
                    return Shift.Morning;
            }
        }

        public static List<WorkShift> GetWorkShiftsByWorkerID(long workerId)
        {
            List<WorkShift> result = new List<WorkShift>();

            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();

            string query =
            @"
                SELECT wws.work_shift_id, wws.worker_id, ws.date as date, ws.shift as shift, ws.wage as wage, ws.workers_needed as workers_needed
                FROM workers_work_shifts wws
                INNER JOIN work_shifts ws
                ON ws.id = wws.work_shift_id
                WHERE wws.worker_id = @workerid
                ORDER BY ws.date ASC
            ";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@workerid",workerId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    long id = workerId;
                    Shift workshift = (Shift)Enum.Parse(typeof(Shift), reader["shift"].ToString());
                    DateTime date = Convert.ToDateTime(reader["date"]);
                    decimal wage = Convert.ToDecimal(reader["wage"]);
                    int workersNeeded = Convert.ToInt32(reader["workers_needed"]);

                    result.Add(new WorkShift(workshift, date, wage, workersNeeded));
                }
            }

            dbConnection.CloseConnection();
            return result;
        }



    }
}
