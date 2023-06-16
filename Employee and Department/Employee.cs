using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_Department
{
    public class Employee
    {
        public string No { get; set; }
        public string FullName { get; set; }
        public int Salary { get; set; }
        public string DepartmentName { get; set; }
        public string position;
        public string Position
        {
            get
            {
                return position;    
            }
            set
            {
                if (value.Length>=2)
                position = value;
                else
                {
                    throw new ArgumentException("Position must contain at least 2 characters.");
                }
                
            }
        }
        public Employee(string no, string fullName, string position, int salary, string departmentName)
        {
            No = no;
            FullName = fullName;
            this.position = position;
            Salary = salary;
            DepartmentName = departmentName;
           
        }
    

    }
}
