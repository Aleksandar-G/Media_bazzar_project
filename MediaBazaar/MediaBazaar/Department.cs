using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Department
    {
        public int Id { get;private set; }
        public string Name { get;private set; }
        public List<Worker> Workers { get; private set; }

        public Department(string name)
        {
            this.Workers = new List<Worker>();
            this.Name = name;
        }

        public Department(string name,List<Worker> workers)
        {
            this.Workers = new List<Worker>();
            this.Name = name;
            this.Workers = workers;
        }


    }
}
