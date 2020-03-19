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

        public long Id { get { return this.id; } }
        public string Name { get { return this.name; } }
        public string Description { get { return this.description; } }
        public double Price { get { return this.price; } }
        public int Quantity { get { return this.quantity; } }

        public Product(long id, string name, string description, double price, int quantity) : base()
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
        }

        public override void Insert()
        {
            dbConnection.OpenConnection();
            string query = "INSERT INTO products(Name, Description, Price, Quantity) VALUES(@name, @description, @price, @quantity)";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@quantity", quantity);

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
            string query = $"DELETE FROM products where id = {id}";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
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

        public static List<string> GetAllProducts()
        {
            List<string> listProducts = new List<string>();

            DBconnection dbConnection = new DBconnection();

            string selectQuery = "SELECT * FROM products";
            dbConnection.OpenConnection();
            MySqlCommand command = new MySqlCommand(selectQuery, dbConnection.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listProducts.Add(reader.GetString("Name"));
            }

            dbConnection.CloseConnection();

            return listProducts;
        }

    }
}
