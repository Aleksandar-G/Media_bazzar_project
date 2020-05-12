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
        private double price;
        private int quantity;
        private string department;

        public long Id { get { return this.id; } }
        public string Name { get { return this.name; } }
        public string Description { get { return this.description; } }
        public double Price { get { return this.price; } }
        public int Quantity { get { return this.quantity; } }
        public string Department { get { return this.department; } }

        public Product(string name, string description, double price, int quantity, string department) : base()
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
            this.department = department;
        }

        public Product(long id, string name, string description, double price, int quantity, string department) : base()
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
            this.department = department;
        }

        public override void Insert()
        {
            dbConnection.OpenConnection();
            string query = "INSERT INTO products(name, description, price, quantity, department_id) VALUES(@name, @description, @price, @quantity, (SELECT id FROM departments WHERE name = @department))";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@quantity", quantity);
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
            string query = $"SELECT COUNT(*) as num ,d.Name as name FROM products as p INNER JOIN departments as d ON p.Department_id = d.Id GROUP BY d.Name;";

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

        public static List<Product> GetAll()
        {
            DBconnection dbConnection = new DBconnection();
            dbConnection.OpenConnection();
            List<Product> products = new List<Product>();
            string query = "SELECT products.id AS p_id, products.name AS p_name, description, price, quantity, departments.name AS d_name FROM products INNER JOIN departments ON products.department_id = departments.id";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader["p_id"]);
                    string name = reader["p_name"].ToString();
                    string description = reader["description"].ToString();
                    double price = Convert.ToDouble(reader["price"]);
                    int quantity = Convert.ToInt32(reader["quantity"]);
                    string department = reader["d_name"].ToString();

                    products.Add(new Product(id, name, description, price, quantity, department));
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
            string query = "SELECT products.id AS p_id, products.name AS p_name, description, price, quantity, departments.name AS d_name FROM products INNER JOIN departments ON products.department_id = departments.id WHERE products.name = @name";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@name", productName);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader["p_id"]);
                    string name = reader["p_name"].ToString();
                    string description = reader["description"].ToString();
                    double price = Convert.ToDouble(reader["price"]);
                    int quantity = Convert.ToInt32(reader["quantity"]);
                    string department = reader["d_name"].ToString();

                    product = new Product(id, name, description, price, quantity, department);

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
            string query = "SELECT products.id AS p_id, products.name AS p_name, description, price, quantity, departments.name AS d_name FROM products INNER JOIN departments ON products.department_id = departments.id WHERE products.id = @id";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@id", productId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader["p_id"]);
                    string name = reader["p_name"].ToString();
                    string description = reader["description"].ToString();
                    double price = Convert.ToDouble(reader["price"]);
                    int quantity = Convert.ToInt32(reader["quantity"]);
                    string department = reader["d_name"].ToString();

                    product = new Product(id, name, description, price, quantity, department);

                    dbConnection.CloseConnection();
                    return product;
                }
                dbConnection.CloseConnection();
                return null;
            }

        }
    }
}
