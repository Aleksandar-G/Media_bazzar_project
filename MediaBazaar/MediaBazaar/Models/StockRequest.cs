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
        //public string DepartmentName { get; private set; }
        //public Dictionary<string, int> ProductsAndQuantity { get; private set; }
        //public string WorkerName { get; private set; }
        //public int Worker { get; set; }
        //public string RequestedProduct { get; set; }
        //public int RequestedQuantity { get; set; }
        //public StockRequest(string departmentName, string Reqproduct, int ReqQuantity, string worker)
        //{
        //    ProductsAndQuantity = new Dictionary<string, int>();
        //    this.DepartmentName = departmentName;

        //    this.RequestedProduct = Reqproduct;
        //    this.RequestedQuantity = ReqQuantity;
        //    this.WorkerName = worker;
        //}
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
                int id = 0;
                int quantity = 0;
                int completed = 0;
                int product_id = 0;
                int worker_id = 0;

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    quantity = Convert.ToInt32(reader["quantity"]);
                    completed = Convert.ToInt32(reader["completed"]);
                    product_id = Convert.ToInt32(reader["product_id"]);
                    worker_id = Convert.ToInt32(reader["worker_id"]);
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
                int id = 0;
                int quantity = 0;
                int completed = 0;
                int product_id = 0;
                int worker_id = 0;

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    quantity = Convert.ToInt32(reader["quantity"]);
                    completed = Convert.ToInt32(reader["completed"]);
                    product_id = Convert.ToInt32(reader["product_id"]);
                    worker_id = Convert.ToInt32(reader["worker_id"]);

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

        //public static List<StockRequest> GetAll()
        //{
        //    DBconnection dbConnection = new DBconnection();
        //    dbConnection.OpenConnection();
        //    List<StockRequest> stockRequests = new List<StockRequest>();
        //    string query = @"SELECT u.name as worker, d.name as dName, p.name as pName, sr.quantity, sr.product_id 
        //                     FROM stock_requests as sr 
        //                     INNER JOIN products as p ON sr.product_id = p.id
        //                     INNER JOIN departments as d ON p.department_id = d.id
        //                     INNER JOIN workers as w ON sr.worker_id = w.id 
        //                     INNER JOIN users as u ON w.user_id = u.id";
        //    using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
        //    {
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        string department = "";
        //        string worker = "";
        //        string productname = "";
        //        int productQuantity = 0;

        //        while (reader.Read())
        //        {
        //            department = reader["dName"].ToString();
        //            worker = reader["worker"].ToString();
        //            productname = reader["pName"].ToString();
        //            productQuantity = Convert.ToInt32(reader["quantity"].ToString());
        //            stockRequests.Add(new StockRequest(department, productname, productQuantity, worker));
        //        }
  
        //        dbConnection.CloseConnection();
        //        return stockRequests;
        //    }
        //}
    }
}
