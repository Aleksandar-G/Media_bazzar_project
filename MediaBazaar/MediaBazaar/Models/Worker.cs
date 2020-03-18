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
        private Workshift workshift;

        public Worker(string name, string email, string phone, long departmentId, Workshift workshift) : base(name, email, phone)
        {
            this.userId = base.id;
            this.departmentId = departmentId;
            this.workshift = workshift;
        }

        public Worker(long id, long departmentId, Workshift workshift, User user) : base(user)
        {
            this.userId = user.Id;
            this.departmentId = departmentId;
            this.workshift = workshift;
        }

        public override void Insert()
        {
            base.Insert();

            dbConnection.OpenConnection();
            string query = "INSERT INTO Workers(user_id, department_id, workshift) VALUES(@userId, @departmentId, @workshift)";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@userId", base.Id);
                cmd.Parameters.AddWithValue("@departmentId", this.departmentId);
                cmd.Parameters.AddWithValue("@workshift", this.workshift.ToString("G"));

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
                    Workshift workshift = (Workshift)Enum.Parse(typeof(Workshift), reader["workshift"].ToString());

                    User user = User.GetById(userId);

                    workers.Add(new Worker(id, departmentId, workshift, user));
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
                    Workshift workshift = (Workshift)Enum.Parse(typeof(Workshift), reader["workshift"].ToString());

                    worker = new Worker(id, departmentId, workshift, user);

                    dbConnection.CloseConnection();
                    return worker;
                }
            }

            dbConnection.CloseConnection();
            return null;
        }

        public override void Update(Model newWorker)
        {
            Worker worker = (Worker)newWorker;
            dbConnection.OpenConnection();

            string query = $"UPDATE users SET user_id = @user_id, department_id = @department_id, workshift = @workshift WHERE id = @workerId";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@user_id", worker.userId);
                cmd.Parameters.AddWithValue("@department_id", worker.departmentId);
                cmd.Parameters.AddWithValue("@workshift", worker.workshift.ToString("G"));

                cmd.ExecuteNonQuery();
            }

            dbConnection.CloseConnection();
        }

        public static Dictionary<long,string> GetAllWorkersWithoutDepartment()
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            //List<User> workers = new List<User>();
            Dictionary<long, string> workers = new Dictionary<long, string>();
            string query = "SELECT u.Name, u.Id,u.Email,u.Password,u.Phone FROM users as u INNER JOIN workers as w ON u.Id = w.user_id WHERE w.Department_id IS NULL";

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

        public static void AssignWorkerToDepartment(long id,long DepartmentId)
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
    }
}
