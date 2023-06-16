using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_Department
{
    public interface IHumanResourceManager
    {
        List<Department> Departments { get; }
        void AddDepartment(string name, int workerLimit, int salaryLimit);
        List<Department> GetDepartments();
        void EditDepartment (string oldName,string newName);
        void AddEmployee(string fullName, string position, int salary, string departmentName);
        void RemoveEmployee(string employeeNo, string departmentName);
        void EditEmployee(string employeeNo,int salary,string position);

       
    }
}
