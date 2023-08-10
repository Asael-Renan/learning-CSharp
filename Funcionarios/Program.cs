namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            
            Console.Write("Quantos funcionarios serão adicionados?: ");
            int quantos = int.Parse(Console.ReadLine() ?? "1");

            for (int i = 0; i < quantos; i++) {
                Employee funcionario = new Employee();
                Console.Write("Id: ");
                funcionario.id = int.Parse(Console.ReadLine() ?? "1");
                Console.Write("Nome: ");
                funcionario.name = Console.ReadLine() ?? "Maria";
                Console.Write("Salario: ");
                funcionario.salary = double.Parse(Console.ReadLine() ?? "1");
                list.Add(funcionario);
                Console.WriteLine();
            }

            Console.WriteLine("Digite o ID para aumentar o salário: ");
            int idFuncionario = int.Parse(Console.ReadLine() ?? "0");
            Employee idFind = list.Find(x => x.id == idFuncionario);

            if (idFind != null) {
                Console.WriteLine("em Quantos irá aumentar o salario? ");
                idFind.increaseSalary(double.Parse(Console.ReadLine() ?? "0"));
            } else {
                Console.WriteLine("usuario não existe.");
            }
            Console.WriteLine("------------------------");
            Console.WriteLine();
            foreach(Employee obj in list) {
                Console.WriteLine($"Id: {obj.id}, {obj.name}, {obj.salary}");
            }
        }
    }
}