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
        public string DepartmentName { get; private set; }
        public Dictionary<string, int> ProductsAndQuantity { get; private set; }
        public string WorkerName { get; private set; }
        public int Worker { get; set; }
        public string RequestedProduct { get; set; }
        public int RequestedQuantity { get; set; }
        public StockRequest(string departmentName, string Reqproduct, int ReqQuantity, string worker)
        {
            ProductsAndQuantity = new Dictionary<string, int>();
            this.DepartmentName = departmentName;

            this.RequestedProduct = Reqproduct;
            this.RequestedQuantity = ReqQuantity;
            this.WorkerName = worker;
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
            string query = @"SELECT u.name as worker, d.name as dName, p.name as pName, sr.quantity, sr.product_id 
                             FROM stock_requests as sr 
                             INNER JOIN products as p ON sr.product_id = p.id
                             INNER JOIN departments as d ON p.department_id = d.id
                             INNER JOIN workers as w ON sr.worker_id = w.id 
                             INNER JOIN users as u ON w.user_id = u.id";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                string department = "";
                string worker = "";
                string productname = "";
                int productQuantity = 0;

                while (reader.Read())
                {
                    department = reader["dName"].ToString();
                    worker = reader["worker"].ToString();
                    productname = reader["pName"].ToString();
                    productQuantity = Convert.ToInt32(reader["quantity"].ToString());
                    stockRequests.Add(new StockRequest(department, productname, productQuantity, worker));
                }
  
                dbConnection.CloseConnection();
                return stockRequests;
            }
        }
    }
}
