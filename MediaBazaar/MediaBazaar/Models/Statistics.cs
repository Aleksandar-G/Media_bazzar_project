using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Models
{
    public class Statistics { 
        //private List<Workers> workers; //chart -> number of workers by department
        //private List<Products> products;
        //private List<StockRequest> requests;
        //private Department selectedDepartment;
    private List<string> departments;
        private List<int> workers;

        //constructors
        public Statistics()
        {
            this.departments = new List<string>() { "Electronics", "Equipment","Department 3" };
            this.workers = new List<int>() { 10, 13, 25 };
        }
        
        public List<int> GetWorkers()
        {
            return this.workers;
        }
        public List<string> GetDepartments()
        {
            return this.departments;
        }
    }
}
