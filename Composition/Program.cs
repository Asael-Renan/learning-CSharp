using System;
using Composition.Entites;
using Composition.Entites.Enums;

namespace Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Enter department's name: ");
            // String? deptName = Console.ReadLine();
            // Console.WriteLine("Enter worker Data: ");
            // Console.Write("Name: ");
            // String? name = Console.ReadLine();
            // Console.Write("Level (Junior/MidLevel/Senior): ");
            // WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            String deptName = "Departamento";
            String name = "Asael Renan";
            double baseSalary = 1200.00;
            WorkerLevel level = Enum.Parse<WorkerLevel>("Junior");

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);
            
            HourContract contract1 = new HourContract(new DateTime(2008, 10, 3), 4.00, 3);
            HourContract contract2 = new HourContract(new DateTime(2008, 10, 7), 5.00, 4);

            worker.AddContract(contract1);
            worker.AddContract(contract2);
            double sum = worker.Income(2008, 10);
            Console.WriteLine(sum);
        }
    }
}