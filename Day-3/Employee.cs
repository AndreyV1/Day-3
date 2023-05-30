using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Employee
    {
        private static int idCounter = 1;
        private int id;
        private string fullName;
        private int department;
        private double salary;

        public Employee(string fullName, int department, double salary)
        {
            this.id = idCounter++;
            this.fullName = fullName;
            this.department = department;
            this.salary = salary;
        }

        public int Id
        {
            get { return id; }
        }

        public string FullName
        {
            get { return fullName; }
        }

        public int Department
        {
            get { return department; }
            set { department = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public static void PrintAllEmployees(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine("ID: {0}, ФИО: {1}, Отдел: {2}, Зарплата: {3}", employee.Id, employee.FullName, employee.Department, employee.Salary);
            }
        }

        public static double CalculateTotalSalary(Employee[] employees)
        {
            double totalSalary = 0;
            foreach (Employee employee in employees)
            {
                totalSalary += employee.Salary;
            }
            return totalSalary;
        }

        public static Employee FindEmployeeWithMinSalary(Employee[] employees)
        {
            Employee minSalaryEmployee = employees[0];
            foreach (Employee employee in employees)
            {
                if (employee.Salary < minSalaryEmployee.Salary)
                {
                    minSalaryEmployee = employee;
                }
            }
            return minSalaryEmployee;
        }

        public static Employee FindEmployeeWithMaxSalary(Employee[] employees)
        {
            Employee maxSalaryEmployee = employees[0];
            foreach (Employee employee in employees)
            {
                if (employee.Salary > maxSalaryEmployee.Salary)
                {
                    maxSalaryEmployee = employee;
                }
            }
            return maxSalaryEmployee;
        }

        public static double CalculateAverageSalary(Employee[] employees)
        {
            double totalSalary = CalculateTotalSalary(employees);
            return totalSalary / employees.Length;
        }
    }
}
