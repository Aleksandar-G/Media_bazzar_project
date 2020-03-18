using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazaar.Models
{
    public class Statistics
    {
        //private List<Workers> workers; //chart -> number of workers by department
        //private List<Products> products;
        //private List<StockRequest> requests;
        //private Department selectedDepartment;
        private List<string> departments;
        private List<int> workers;
        private DBconnection dBconnection;
        //constructors
        public Statistics()
        {
            this.departments = new List<string>();
            this.workers = new List<int>() { 10, 13, 25, 60 };

        }

        public List<int> GetWorkers()
        {
            return this.workers;
        }
        public List<string> GetDepartments()
        {
            this.dBconnection = new DBconnection();
            string query = "SELECT Name FROM departmens";
            using (MySqlCommand cmd = new MySqlCommand(query, dBconnection.connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.departments.Add(reader["Name"].ToString());
                }
            }
            dBconnection.CloseConnection();
            return this.departments;
        }
    }
}
