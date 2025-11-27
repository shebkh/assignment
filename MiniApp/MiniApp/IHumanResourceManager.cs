using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApp
{
    public interface IHumanResourceManager
    {
        List<Department> Departments { get; }

        void AddDepartment(string name, int workerLimit, double salaryLimit);
        List<Department> GetDepartments();
        void EditDepartments(string oldName, string newName);

        void AddEmployee(string fullname, string position, double salary, string departmentName);
        void RemoveEmployee(string employeeNo, string departmentName);
        void EditEmployee(string no, double newSalary, string newPosition);

        List<Employee> Search(string searchText);
    }
}