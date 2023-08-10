using Inheritance4.Entities;

namespace Inheritance4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine() ?? "1");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write($"Common, used or imported (c/u/i): ");
                string? Type = Console.ReadLine();
                Console.Write("Name: ");
                string? Name = Console.ReadLine();
                Console.Write("Price: ");
                double Price = double.Parse(Console.ReadLine() ?? "0");

                if (Type == "i")
                {
                    Console.Write("Customs fee: ");
                    double CustomsFee = double.Parse(Console.ReadLine() ?? "0");
                    products.Add(new ImportedProduct(Name ?? "", Price, CustomsFee));
                }
                else if (Type == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYY): ");
                    DateOnly ManufactureDate = DateOnly.Parse(Console.ReadLine() ?? "0");
                    products.Add(new UsedProduct(Name ?? "", Price, ManufactureDate));
                }
                else if (Type == "c")
                {
                    products.Add(new Product(Name ?? "", Price));
                }
                else
                {
                    Console.WriteLine("Valor invalido");
                }
            }

            Console.WriteLine("Price tags:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}