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
    public class LeaveRequest : Model
    {
        public long Id { get; private set; }
        public Worker Worker { get; private set; }
        public string Description { get; private set; }
        public int Accepted { get; private set; }
        public int Pending { get; private set; }
        public DateTime From { get; private set; }
        public DateTime To { get; private set; }


        public LeaveRequest(long id, int workerID, DateTime from, DateTime to, int accepted, int pending,string description)
        {
            this.Id = id;
            this.Worker = Worker.GetById(workerID);
            this.From = from;
            this.To = to;
            this.Accepted = accepted;
            this.Pending = pending;
            this.Description = description;
        }
        public override void Delete()
        {
            throw new NotImplementedException();
        }
        public override void Insert()
        {
            throw new NotImplementedException();
        }
        public override void Update(Model obj)
        {
            throw new NotFiniteNumberException();

        }
        public void Update(Model obj, bool isApproved)
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            LeaveRequest request = (LeaveRequest)obj;
            string query;
            if (isApproved)
            {
                query = $"UPDATE leaves SET pending = 0 ,approved= 1 WHERE id ={request.Id}";
            }
            else
            {
                query = $"UPDATE leaves SET pending = 0 ,approved= 0 WHERE id ={request.Id}";
            }
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.ExecuteNonQuery();
            }
            dbConnection.CloseConnection();
        }
        public static List<LeaveRequest> GetAll()
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            List<LeaveRequest> requests = new List<LeaveRequest>();
            string query = "SELECT * FROM leaves WHERE pending = 1";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader["id"]);
                    int workerId = Convert.ToInt32(reader["worker_id"]);
                    int accepted = Convert.ToInt32(reader["approved"]);
                    int pending = Convert.ToInt32(reader["pending"]);
                    DateTime from = DateTime.Parse(reader["from"].ToString());
                    DateTime to = DateTime.Parse(reader["to"].ToString());
                    string description = reader["description"].ToString();
                    requests.Add(new LeaveRequest(id, workerId, from, to, accepted, pending,description));
                }
            }
            dbConnection.CloseConnection();
            return requests;
        }
        public string GetInfo()
        {
            return $"{this.Worker.Name} - {this.From.ToString("dd-MM-yyyy")}:{this.To.ToString("dd-MM-yyyy")}";
        }
    }
}
