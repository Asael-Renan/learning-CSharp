using Payers.Entities;

namespace Payers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine() ?? "1");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char Type = char.Parse(Console.ReadLine() ?? "i");
                Console.Write("Name: ");
                string Name = Console.ReadLine() ?? "";
                Console.Write("Anual income: ");
                double AnualIncome = double.Parse(Console.ReadLine() ?? "0");

                if (Type == 'i')
                {
                    Console.Write("Healt expenditures: ");
                    double HealtExpenditures = double.Parse(Console.ReadLine() ?? "0");
                    list.Add(new Individual(Name, AnualIncome, HealtExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int NumberOfEmployees = int.Parse(Console.ReadLine() ?? "0");
                    list.Add(new Individual(Name, AnualIncome, NumberOfEmployees));
                }
            }

            double TotalTaxes = 0;
            Console.WriteLine("TAXES PAID");
            foreach (TaxPayer payer in list)
            {
                Console.WriteLine($"{payer.Name}: ${payer.Tax()}");
                TotalTaxes += payer.Tax();
            }

        
            Console.Write($"TOTAL TAXES: {TotalTaxes}");

        }
    }
}