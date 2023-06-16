using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_Department
{
    public class HumanResourceManager : IHumanResourceManager
    {
        
        public List<Department> Departments { get; }
        public HumanResourceManager()
        {
            Departments = new List<Department>();
        }
        public void AddDepartment(string name, int workerLimit, int salaryLimit)
        {
            Department department = new Department();
            if (workerLimit<1||salaryLimit<250)
            {
                Console.WriteLine(" Worker limit must be at least 1 and salary limit must be at least 250.");
                 return;
            }
            Department newDepartment = new Department
            {
                Name = name,
                WorkerLimit = workerLimit,
                SalaryLimit = salaryLimit,
                Employees = new List<Employee>()
            };
            Departments.Add(newDepartment);
            Console.WriteLine("Department created successfully");
        
        }
   
        public void AddEmployee(string fullName, string position, int salary, string departmentName)
        {
            if (salary<250)
            {
                Console.WriteLine("Minimum salary is 250.");
                return;
            }
            Department department = Departments.Find(o => o.Name == departmentName);
            if (department!=null)
            {
                int totalSalary = department.CalculateTotalSalary() + salary;
                if (department.Employees.Count< department.WorkerLimit && totalSalary < department.SalaryLimit)
                {
                    string twoLetters = departmentName.Substring(0, 2).ToUpper();
                    string createdEmployeeNo = twoLetters + (1000 + department.Employees.Count + 1);
                    Employee employee = new Employee(createdEmployeeNo, fullName, position, salary, departmentName);
                    department.Employees.Add(employee);
                }
              
                else
                {
                    Console.WriteLine("Error: Salary or Worker limit exceeded for the department.");
                }
            }
            else
            {
                Console.WriteLine("Error: Department not found.");
            }
        }
        public void EditDepartment(string oldName, string newName)
        {
            Department department = Departments.Find(o => o.Name == oldName);

            if(department!=null)
            {
                department.Name = newName;
                Console.WriteLine("Department updated successfully.");
            }
            else
            {
                Console.WriteLine("Department not found.");
            }
        }
       
        public void EditEmployee(string employeeNo, int salary, string position)
        {
            if (salary < 250)
            {
                Console.WriteLine("Minimum salary is 250.");
                return;
            }

            foreach (Department department in Departments)
            {
                Employee employee = department.Employees.Find(o => o.No == employeeNo);
                int totalSalary = department.CalculateTotalSalary() + salary;
                if (employee!=null&& totalSalary<department.SalaryLimit)
                {
                    employee.No = employeeNo;
                    employee.Salary = salary;
                    employee.position = position;
                    Console.WriteLine("Employee updated successfully.");
                    return;
                }
            }
            Console.WriteLine("Employee not found.");

        }

        public List<Department> GetDepartments()
        {
            return Departments;
        }

        public void RemoveEmployee(string employeeNo, string departmentName)
        {
            Department department = Departments.Find(o => o.Name == departmentName);
            if (department!=null)
            {
                Employee employee = department.Employees.Find(o => o.No == employeeNo);
                if (employee!=null)
                {
                    department.Employees.Remove(employee);
                    Console.WriteLine("Employee removed successfully.");

                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
            }
            else
            {
                Console.WriteLine("Department not found.");
            }
        }

    }
}
