using Exeption.Entities;
using Exeption.Entities.Exceptions;

namespace Exeption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int Number = int.Parse(Console.ReadLine() ?? "0");
                Console.Write("Holder: ");
                string Holder = Console.ReadLine() ?? "";
                Console.Write("Initial Balance: ");
                double InitialBalance = double.Parse(Console.ReadLine() ?? "0.0");
                Console.Write("Withdraw limit: ");
                double WithdrawLimit = double.Parse(Console.ReadLine() ?? "0.0");

                Account acc = new Account(Number, Holder, InitialBalance, WithdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double WithdrawAmount = double.Parse(Console.ReadLine() ?? "0.0");

                acc.Withdraw(WithdrawAmount);

                Console.WriteLine($"New balance: {acc.Balance.ToString("F2")}");
            }
            catch (InvalidWithdrawalException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
        }
    }
}