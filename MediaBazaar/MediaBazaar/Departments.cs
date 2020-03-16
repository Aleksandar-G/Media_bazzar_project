using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Departments
    {
        public List<Department> AllDepartments { get; private set; }

        public Departments()
        {
            AllDepartments = new List<Department>();
        }

        public void AddDepartment(string name)
        {
            Department department = new Department(name);

            AllDepartments.Add(department);
        }

        public void AddDepartment(string name,List<Worker> workers)
        {
            Department department = new Department(name,workers);

            AllDepartments.Add(department);
        }
    }
}
