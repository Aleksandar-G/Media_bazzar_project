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
        public string AdminName { get; private set; }
        public StockRequest(string departmentName, Dictionary<string, int> productAndQuantity, string admin)
        {
            ProductsAndQuantity = new Dictionary<string, int>();
            this.DepartmentName = departmentName;
            this.ProductsAndQuantity = productAndQuantity;
            this.AdminName = admin;
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
            Dictionary<string, int> productsQuantity = new Dictionary<string, int>();
            string query = @"SELECT u.name as admin, d.name as dName, p.name as pName, sr.quantity, sr.product_id 
                             FROM stock_requests as sr 
                             INNER JOIN products as p ON sr.product_id = p.id
                             INNER JOIN departments as d ON p.department_id = d.id
                             INNER JOIN workers as w ON sr.worker_id = w.id 
                             INNER JOIN users as u ON w.user_id = u.id";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                string department = "";
                string admin = "";

                while (reader.Read())
                {
                    department = reader["dName"].ToString();
                    admin = reader["admin"].ToString();
                    string productname = reader["pName"].ToString();
                    int productQuantity = Convert.ToInt32(reader["quantity"].ToString());

                    productsQuantity.Add(productname, productQuantity);
                }

                stockRequests.Add(new StockRequest(department, productsQuantity, admin));
                dbConnection.CloseConnection();
                return stockRequests;
            }
        }
    }
}
