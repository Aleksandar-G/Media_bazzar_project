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


    }
}
