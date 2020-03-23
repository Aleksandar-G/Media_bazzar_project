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
            string query = "SELECT u.Name as admin, d.Name as dName, p.Name as pName, rp.Quantity FROM stockrequested as sr INNER JOIN requestedproducts as rp ON sr.Id = rp.Requested_Id INNER JOIN products as p ON rp.Product_id = p.Id INNER JOIN departments as d ON sr.Department_id = d.Id INNER JOIN administrators as a ON sr.Admin_id = a.Id INNER JOIN users as u ON a.user_id = u.Id";
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
                    int productQuantity = Convert.ToInt32(reader["Quantity"].ToString());

                    productsQuantity.Add(productname, productQuantity);

                    
                    //users.Add(new User(id, name, email, password, phone, role));
                }
                stockRequests.Add(new StockRequest(department, productsQuantity, admin));
                dbConnection.CloseConnection();
                return stockRequests;
            }
        }
    }
}
