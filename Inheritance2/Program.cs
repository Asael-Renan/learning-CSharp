using System;
using Inheritance3.Entities;

namespace Inheritance3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();

            Console.Write("Enter the number of Employees: ");
            int EmployeesNumber = int.Parse(Console.ReadLine() ?? "1");

            for (int i = 0; i < EmployeesNumber; i++)
            {
                Console.WriteLine($"Employee: #{i + 1} data:");
                Console.Write($"Outsourced (y/n) : ");
                string Outsourced = Console.ReadLine() ?? "n";
                Console.Write($"Name : ");
                string? Name = Console.ReadLine();
                Console.Write($"Hours : ");
                int Hours = int.Parse(Console.ReadLine() ?? "0");
                Console.Write($"Value per hour: ");
                double ValuePerHour = double.Parse(Console.ReadLine() ?? "0.0");
                if (Outsourced == "y")
                {
                    Console.Write($"Adicional charger: ");
                    double AdicionalCharge = double.Parse(Console.ReadLine() ?? "0.0");
                    Employees.Add(new OutsourcedEmployee(Name, Hours, ValuePerHour, AdicionalCharge));
                }
                else
                {
                    Employees.Add(new Employee(Name, Hours, ValuePerHour));
                }
            }

            Console.WriteLine();
            foreach (Employee employee in Employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}