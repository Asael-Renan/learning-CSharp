using Composition.Entites.Enums;
namespace Composition.Entites
{
    class Worker
    {
        public String? Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament? Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        Worker()
        {
        }

        public Worker(string? name, WorkerLevel level, double baseSalary, Departament? departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int mounth)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == mounth)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
