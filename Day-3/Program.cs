using Day_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("fio", 10000, 1);
        List<Employee> employees = new List<Employee>()
        {
                new Employee("Иванов Иван Иванович", 25000, 1),
                new Employee("Петров Петр Петрович", 30200, 2),
                new Employee("Сидорова Анна Ивановна", 52000, 3),
                new Employee("Кузнецова Елена Александровна", 47000, 4),
                new Employee("Смирнов Алексей Владимирович", 70000, 5),
                new Employee("Новиков Дмитрий Сергеевич", 40700, 1),
                new Employee("Морозова Ольга Викторовна", 50000, 2),
                new Employee("Козлов Андрей Игоревич", 55000, 3),
                new Employee("Лебедева Наталья Александровна", 60500, 4),
                new Employee("Григорьев Сергей Васильевич", 65000, 5)

        };

        void Employee()
        {
            Console.WriteLine("Employee");
            foreach (var emp in employees)
            {

                Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}, Отдел: {emp.Department}");
            }
        }

        void TotalSalary()
        {
            Console.WriteLine("TotalSalary");
            double summa = 0;
            foreach (var emp in employees)
            {
                summa += emp.Salary;
            }
            Console.WriteLine($"Сумма затрат на зарплату в месяц: {summa}");
        }

        void MinSalary()
        {
            Console.WriteLine("MinSalary");
            double min = 99999;
            foreach (var emp in employees)
            {
                if (emp.Salary < min)
                {
                    min = emp.Salary;
                }
            }
            Console.WriteLine("Минимальная зарплата " + min);
        }

        void MaxSalary()
        {
            Console.WriteLine("MaxSalary");
            double max = 0;
            foreach (var emp in employees)
            {
                if (emp.Salary > max)
                {
                    max = emp.Salary;
                }
            }
            Console.WriteLine("Максимальная зарплата " + max);
        }

        void AverageSalary()
        {
            Console.WriteLine("AverageSalary");
            int count = 0;
            double summa = 0;
            foreach (var emp in employees)
            {
                count++;
                summa += emp.Salary;
            }

            Console.WriteLine($"Среднее значение зарплаты: {summa / count}");
        }

        void FullName()
        {
            Console.WriteLine("FullName");
            foreach (var emp in employees)
            {
                Console.WriteLine("ФИО " + emp.Fio);
            }
            Console.ReadKey();
        }

        Employee();
        Console.WriteLine();
        TotalSalary();
        Console.WriteLine();
        MinSalary();
        Console.WriteLine();
        MaxSalary();
        Console.WriteLine();
        AverageSalary();
        Console.WriteLine();
        FullName();
    }
}

