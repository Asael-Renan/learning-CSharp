namespace Program{
    internal class Program {
        static void Main(string[] args){
            double Dinheiro = 0;
            Console.Write("Entre com o numero da conta: ");
            int NumConta = Convert.ToInt16(Console.ReadLine());
            Console.Write("Entre com o nome: ");
            string Nome = Console.ReadLine() ?? "";
            Console.Write("Hávera deposito inicial (s/n)? ");
            char DepositoInicial = Convert.ToChar(Console.ReadLine() ?? "n");
            if (new char[] {'S', 's'}.Contains(DepositoInicial)) {
                Console.Write("Entre com o valor de deposito inicial: ");
                Dinheiro = Convert.ToDouble(Console.ReadLine());
            }

            Banco banco = new Banco(NumConta, Nome, Dinheiro);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine("Conta: " + banco.NumConta + ", Titular: " + banco.Nome + ", Saldo: " + banco.Dinheiro);

            Console.Write("Valor de deposito: ");
            banco.Depositar(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Conta: " + banco.NumConta + ", Titular: " + banco.Nome + ", Saldo: " + banco.Dinheiro);

            Console.Write("Valor de saque: ");
            banco.Sacar(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Conta: " + banco.NumConta + ", Titular: " + banco.Nome + ", Saldo: " + banco.Dinheiro);

        }
    }
}