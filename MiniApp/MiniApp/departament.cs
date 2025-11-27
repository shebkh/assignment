using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApp
    {
    public class Department
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 2)
                    throw new Exception("Department name minimum 2 letters.");
                _name = value;
            }
        }

        private int _workerLimit;
        public int WorkerLimit
        {
            get => _workerLimit;
            set
            {
                if (value < 1)
                    throw new Exception("Worker limit must be at least 1.");
                _workerLimit = value;
            }
        }

        private double _salaryLimit;
        public double SalaryLimit
        {
            get => _salaryLimit;
            set
            {
                if (value < 250)
                    throw new Exception("Salary limit minimum 250.");
                _salaryLimit = value;
            }
        }

        public List<Employee> Employees { get; set; }

        public Department(string name, int workerLimit, double salaryLimit)
        {
            Name = name;
            WorkerLimit = workerLimit;
            SalaryLimit = salaryLimit;
            Employees = new List<Employee>();
        }

        public double CalcSalaryAverage()
        {
            if (Employees.Count == 0) return 0;

            return Employees.Average(e => e.Salary);
        }
    }
}
