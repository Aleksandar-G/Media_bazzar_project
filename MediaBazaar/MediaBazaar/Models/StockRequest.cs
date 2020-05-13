using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazaar.Models
{
    public class StockRequest : Model
    {
        public int Id { get; private set; }
        public int Quantity { get; private set; }
        public int Completed { get; private set; }
        public Product Product { get; private set; }
        public Worker Worker { get; private set; }

        public StockRequest(int id, int quantity, int completed, int productId, int workerId)
        {
            this.Id = id;
            this.Quantity = quantity;
            this.Completed = completed;
            this.Product = Product.GetById(productId);
            this.Worker = Worker.GetById(workerId);
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
            throw new NotImplementedException();
        }

        public static List<StockRequest> GetAll()
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            List<StockRequest> stockRequests = new List<StockRequest>();
            string query = "SELECT id, quantity, completed, product_id, worker_id FROM stock_requests;";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
               
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    int quantity = Convert.ToInt32(reader["quantity"]);
                    int completed = Convert.ToInt32(reader["completed"]);
                    int product_id = Convert.ToInt32(reader["product_id"]);
                    int worker_id = Convert.ToInt32(reader["worker_id"]);
                    stockRequests.Add(new StockRequest(id, quantity, completed, product_id, worker_id));
                }

                dbConnection.CloseConnection();
                return stockRequests;
            }
        }

        public void CompleteStockRequest()
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();

            string query = "UPDATE stock_requests SET completed = 1 WHERE id = @id;";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@id", this.Id);

                cmd.ExecuteNonQuery();
            }

            dbConnection.CloseConnection();
        }

        public static List<StockRequest> GetAllPendingRequests()
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            List<StockRequest> stockRequests = new List<StockRequest>();
            string query = "SELECT id, quantity, completed, product_id, worker_id FROM stock_requests;";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
            
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    int quantity = Convert.ToInt32(reader["quantity"]);
                    int completed = Convert.ToInt32(reader["completed"]);
                    int product_id = Convert.ToInt32(reader["product_id"]);
                    int worker_id = Convert.ToInt32(reader["worker_id"]);

                    if(completed == 0)
                    {
                        stockRequests.Add(new StockRequest(id, quantity, completed, product_id, worker_id));
                    }
                }

                dbConnection.CloseConnection();
                return stockRequests;
            }
        }

        public string GetInfo()
        {
            return $"Request id: {this.Id}, for product {this.Product.Name} - Quantity: {this.Quantity}; sent by worker: {this.Worker.Name}"; 
        }
    }
}
