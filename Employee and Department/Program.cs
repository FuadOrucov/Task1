using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_Department
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHumanResourceManager humanResourceManager = new HumanResourceManager();
            while (true)
            {
                Console.WriteLine("Proses Menu:");
                Console.WriteLine("1.Departments List ");
                Console.WriteLine("2. Create Department");
                Console.WriteLine("3. Edit Department");
                Console.WriteLine("4. Show Employees");
                Console.WriteLine("5. Show Employees in Department");
                Console.WriteLine("6. Add Employee");
                Console.WriteLine("7. Edit Employee");
                Console.WriteLine("8. Remove Employee");
                Console.WriteLine("0. Exit");
                Console.WriteLine();
                Console.Write("Enter a number from 0-8: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        List<Department> departments = humanResourceManager.GetDepartments();
                        if (departments.Count==0)
                        {
                            Console.WriteLine("Department not found");
                            return;
                        }
                        foreach (Department department in departments)
                        {
                            double averageSalary = department.CalcSalaryAverage();
                            Console.WriteLine($"Department: {department.Name}, Worker Count:{department.Employees.Count}," +
                                $"Average Salary: {averageSalary}");
                        }
                        break;

                    case 2:
                        Console.Write("Enter department name: ");
                        string departmentName = Console.ReadLine();
                        Console.Write("Enter worker limit: ");
                        int workerLimit = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter salary limit: ");
                        int salaryLimit = Convert.ToInt32(Console.ReadLine());
                        humanResourceManager.AddDepartment(departmentName, workerLimit, salaryLimit);
                        Console.WriteLine("==========================================");
                        break;
                    case 3:
                        Console.Write("Enter department name: ");
                        string oldDepartmentName = Console.ReadLine();
                        Console.Write("Enter new department name: ");
                        string newDepartmentName = Console.ReadLine();
                        humanResourceManager.EditDepartment(oldDepartmentName, newDepartmentName);
                        Console.WriteLine("==========================================");
                        break;
                    case 4:
                        List<Department> departmentWithEmployees = humanResourceManager.GetDepartments();
                        foreach (Department department in departmentWithEmployees)
                        {
                            foreach (Employee employee in department.Employees)
                            {
                                Console.WriteLine($"No: {employee.No}, Full Name: {employee.FullName}," +
                                $" Department: {employee.DepartmentName}, Salary: {employee.Salary}");
                            }
                        }
                        Console.WriteLine("==========================================");
                        break;
                    case 5:
                        Console.Write("Enter department name: ");
                        string departmentToName = Console.ReadLine();
                        Department selectDepartment = humanResourceManager.Departments.Find(o => o.Name == departmentToName);
                        if (selectDepartment!=null)
                        {
                            foreach (Employee employee in selectDepartment.Employees)
                            {
                                Console.WriteLine($"No: {employee.No}, Full Name: {employee.FullName}," +
                                    $" Position: {employee.Position}, Salary: {employee.Salary}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Department not found.");
                        }
                        Console.WriteLine("==========================================");
                        break;
                    case 6:
                        Console.Write("Enter full name: ");
                        string employeeFullName = Console.ReadLine();
                        Console.Write("Enter position: ");
                        string employeePosition = Console.ReadLine();
                        Console.Write("Enter salary: ");
                        int employeeSalary = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter department name: ");
                        string employeeDepartmentName = Console.ReadLine();
                        humanResourceManager.AddEmployee(employeeFullName, employeePosition, employeeSalary, employeeDepartmentName);
                        Console.WriteLine("==========================================");
                        break;
                    case 7:
                        Console.Write("Enter employee number: ");
                        string editEmployeeNo = Console.ReadLine();
                        Console.Write("Enter new salary: ");
                        int newSalary = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter new position: ");
                        string newPosition = Console.ReadLine();
                        humanResourceManager.EditEmployee(editEmployeeNo,newSalary, newPosition);
                        Console.WriteLine("==========================================");
                        break;
                    case 8:
                        Console.Write("Enter employee number: ");
                        string removeEmployeeNo = Console.ReadLine();
                        Console.Write("Enter department name: ");
                        string removeEmployeeDepartment = Console.ReadLine();

                        humanResourceManager.RemoveEmployee(removeEmployeeNo, removeEmployeeDepartment);
                        Console.WriteLine("==========================================");
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Field Choice");
                        Console.WriteLine("==========================================");
                        break;
                }
            }
        }
    }
}
