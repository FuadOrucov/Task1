using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_Department
{
    public class Department
    {
        public string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length>=2)
                
                    name = value;
                else
                {
                    throw new ArgumentException("Name must contain at least 2 characters.");
                }
                
            }
        }
        public int WorkerLimit { get; set; }
        public int SalaryLimit { get; set; }
        public List<Employee> Employees { get; set; }
         
        public double CalcSalaryAverage()
        {
            if (Employees.Count==0)
            {
                return 0;
            }
            double totalSalary = Employees.Sum(o => o.Salary);
            return totalSalary / Employees.Count;
        }

        public int CalculateTotalSalary()
        {
            int totalSalary = 0;
            foreach (Employee employee in Employees)
            {
                totalSalary += employee.Salary;
            }
            return totalSalary;
        }
    }
}
