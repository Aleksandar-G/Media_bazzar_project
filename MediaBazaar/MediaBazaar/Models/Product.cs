using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Models
{
    public class Product : Model
    {
        private long id;
        private string name;
        private string description;
        private double buyingPrice;
        private double sellingPrice;
        private int quantity;
        private int minQuantity;
        private string department;

        public long Id { get { return this.id; } }
        public string Name { get { return this.name; } }
        public string Description { get { return this.description; } }
        public double BuyingPrice { get { return this.buyingPrice; } }
        public double SellingPrice { get { return this.sellingPrice; } }
        public int Quantity { get { return this.quantity; } }
        public int MinQuantity { get { return this.minQuantity; } }
        public string Department { get { return this.department; } }

        public Product(string name, string description, double buyingPrice, double sellingPrice, int quantity, int minQuantity, string department) : base()
        {
            this.name = name;
            this.description = description;
            this.buyingPrice = buyingPrice;
            this.sellingPrice = sellingPrice;
            this.quantity = quantity;
            this.minQuantity = minQuantity;
            this.department = department;
        }

        public Product(long id, string name, string description, double buyingPrice, double sellingPrice, int quantity, int minQuantity, string department) : base()
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.buyingPrice = buyingPrice;
            this.sellingPrice = sellingPrice;
            this.quantity = quantity;
            this.minQuantity = minQuantity;
            this.department = department;
        }

        public override void Insert()
        {
            dbConnection.OpenConnection();
            string query =
            @"
                INSERT INTO products(name, description, buying_price, selling_price, quantity, min_quantity, department_id, created_at, updated_at) 
                VALUES(@name, @description, @buying_price, @selling_price, @quantity, @min_quantity, (SELECT id FROM departments WHERE name = @department), NOW(), NOW())
            ";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@buying_price", buyingPrice);
                cmd.Parameters.AddWithValue("@selling_price", sellingPrice);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@min_quantity", minQuantity);
                cmd.Parameters.AddWithValue("@department", department);

                cmd.ExecuteNonQuery();
                this.id = cmd.LastInsertedId;
            }
        }
        public override void Update(Model obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            dbConnection.OpenConnection();
            string query = $"DELETE FROM products where id = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@id", this.id);
                cmd.ExecuteNonQuery();
            }

            dbConnection.CloseConnection();
        }

        public static Dictionary<string, int> GetProductsByDepartment()
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            Dictionary<string, int> result = new Dictionary<string, int>();
            string query = 
            @"
                SELECT COUNT(*) as num, d.Name as name 
                FROM products as p
                INNER JOIN departments as d 
                ON p.Department_id = d.Id
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

        public static Dictionary<string,int> GetSoldQuantity()
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();

            Dictionary<string, int> productNameSoldQuantity = new Dictionary<string, int>();

            string query =
            @"
                SELECT SUM(od.quantity) as quantity, p.name as name
                FROM orders as o 
                INNER JOIN order_details as od 
                ON o.id = od.order_id
                INNER JOIN products as p
                ON od.product_id = p.id
                GROUP BY od.product_id;
            ";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                //cmd.Parameters.AddWithValue("@productId", productId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    productNameSoldQuantity.Add(reader["name"].ToString(),Convert.ToInt32(reader["quantity"]));

                }
                dbConnection.CloseConnection();

                return productNameSoldQuantity;
            }

        }

        public static Dictionary<string, int> GetProductRevenue()
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();

            Dictionary<string, int> productNamerevenue = new Dictionary<string, int>();

            string query =
            @"
                SELECT p.name, od.quantity*(p.selling_price-p.buying_price) as revenue 
                FROM `order_details` as od 
                INNER JOIN products as p 
                ON od.product_id = p.id 
                GROUP BY(p.id)
            ";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                //cmd.Parameters.AddWithValue("@productId", productId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    productNamerevenue.Add(reader["name"].ToString(), Convert.ToInt32(reader["revenue"]));

                }
                dbConnection.CloseConnection();

                return productNamerevenue;
            }

        }


        public static List<Product> GetAll()
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            List<Product> products = new List<Product>();
            string query = 
            @"
                SELECT products.id AS p_id, products.name AS p_name, description, buying_price, selling_price, quantity, min_quantity, departments.name AS d_name
                FROM products
                INNER JOIN departments
                ON products.department_id = departments.id
            ";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader["p_id"]);
                    string name = reader["p_name"].ToString();
                    string description = reader["description"].ToString();
                    double buyingPrice = Convert.ToDouble(reader["buying_price"]);
                    double sellingPrice = Convert.ToDouble(reader["selling_price"]);
                    int quantity = Convert.ToInt32(reader["quantity"]);
                    int minQuantity = Convert.ToInt32(reader["min_quantity"]);
                    string department = reader["d_name"].ToString();

                    products.Add(new Product(id, name, description, buyingPrice, sellingPrice, quantity, minQuantity, department));
                }
            }

            dbConnection.CloseConnection();
            return products;
        }

        public static Product GetByName(string productName)
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            Product product;
            string query = 
            @"
                SELECT products.id AS p_id, products.name AS p_name, description, buying_price, selling_price, quantity, min_quantity, departments.name AS d_name 
                FROM products 
                INNER JOIN departments 
                ON products.department_id = departments.id 
                WHERE products.name = @name
            ";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@name", productName);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader["p_id"]);
                    string name = reader["p_name"].ToString();
                    string description = reader["description"].ToString();
                    double buyingPrice = Convert.ToDouble(reader["buying_price"]);
                    double sellingPrice = Convert.ToDouble(reader["selling_price"]);
                    int quantity = Convert.ToInt32(reader["quantity"]);
                    int minQuantity = Convert.ToInt32(reader["min_quantity"]);
                    string department = reader["d_name"].ToString();

                    product = new Product(id, name, description, buyingPrice, sellingPrice, quantity, minQuantity, department);

                    dbConnection.CloseConnection();
                    return product;
                }
                dbConnection.CloseConnection();
                return null;
            }

        }

        public static Product GetById(int productId)
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            Product product;
            string query = 
            @"
                SELECT products.id AS p_id, products.name AS p_name, description, buying_price, selling_price, quantity, min_quantity, departments.name AS d_name 
                FROM products 
                INNER JOIN departments 
                ON products.department_id = departments.id 
                WHERE products.id = @id
            ";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@id", productId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader["p_id"]);
                    string name = reader["p_name"].ToString();
                    string description = reader["description"].ToString();
                    double buyingPrice = Convert.ToDouble(reader["buying_price"]);
                    double sellingPrice = Convert.ToDouble(reader["selling_price"]);
                    int quantity = Convert.ToInt32(reader["quantity"]);
                    int minQuantity = Convert.ToInt32(reader["min_quantity"]);
                    string department = reader["d_name"].ToString();

                    product = new Product(id, name, description, buyingPrice, sellingPrice, quantity, minQuantity, department);

                    dbConnection.CloseConnection();
                    return product;
                }
                dbConnection.CloseConnection();
                return null;
            }
        }
        public void IncreaseQuantity(int quantity)
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();

            string query = "UPDATE products, updated_at SET quantity = quantity + @quantity, updated_at = NOW() WHERE id = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@id", this.Id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
