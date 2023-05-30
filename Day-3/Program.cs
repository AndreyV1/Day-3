using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[10];
            employees[0] = new Employee("Иванов Иван Иванович", 1, 25000);
            employees[1] = new Employee("Петров Петр Петрович", 2, 30000);
            employees[2] = new Employee("Сидорова Анна Ивановна", 3, 52000);
            employees[3] = new Employee("Кузнецова Елена Александровна", 4, 47000);
            employees[4] = new Employee("Смирнов Алексей Владимирович", 5, 70000);
            employees[5] = new Employee("Новиков Дмитрий Сергеевич", 1, 40000);
            employees[6] = new Employee("Морозова Ольга Викторовна", 2, 50000);
            employees[7] = new Employee("Козлов Андрей Игоревич", 3, 55000);
            employees[8] = new Employee("Лебедева Наталья Александровна", 4, 60000);
            employees[9] = new Employee("Григорьев Сергей Васильевич", 5, 75000);

            Employee.PrintAllEmployees(employees);

            double totalSalary = Employee.CalculateTotalSalary(employees);
            Console.WriteLine("Общая зарплата: {0}", totalSalary);

            Employee minSalaryEmployee = Employee.FindEmployeeWithMinSalary(employees);
            Console.WriteLine("Сотрудник с минимальной зарплатой: {0}", minSalaryEmployee.FullName);

            Employee maxSalaryEmployee = Employee.FindEmployeeWithMaxSalary(employees);
            Console.WriteLine("Сотрудник с максимальной зарплатой: {0}", maxSalaryEmployee.FullName);

            double averageSalary = Employee.CalculateAverageSalary(employees);
            Console.WriteLine("Средняя зарплата: {0}", averageSalary);
        }
    }
}
