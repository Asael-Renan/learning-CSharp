using Oders.Entities;
using Oders.Entities.Enums;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Client data
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            String? Name = Console.ReadLine();
            Console.Write("Email: ");
            String? Email = Console.ReadLine();
            Console.Write("Brith date (DD/MM/YYYY): ");
            DateTime BrithDate = DateTime.Parse(Console.ReadLine());


            Client Client = new Client(Name, Email, BrithDate);

            //Order data
            Console.WriteLine("Enter order data:");
            Console.Write("Order Status: ");
            OrderStatus Status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("Order quantity: ");
            int ItemsQuantity;
            int.TryParse(Console.ReadLine(), out ItemsQuantity);

            Order Order = new Order(Status, Client);

            for (int i = 1; i < ItemsQuantity + 1; i++)
            {
                Console.WriteLine("Enter #" + i + " item data: ");
                Console.Write("Product Name: ");
                String? ProductName = Console.ReadLine();
                Console.Write("Product Price: ");
                double ProductPrice;
                double.TryParse(Console.ReadLine(), out ProductPrice);
                Console.Write("Quantity: ");
                int Quantity;
                int.TryParse(Console.ReadLine(), out Quantity);

                Product Product = new Product(ProductName, ProductPrice);
                OrderItem OrderItem = new OrderItem(Quantity, ProductPrice, Product);

                Order.AddItem(OrderItem);
            }

            Console.WriteLine();
            Console.WriteLine("Order sumary:");
            Console.WriteLine(Order.ToString());

        }
    }
}