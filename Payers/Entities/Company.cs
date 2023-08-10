
using Payers.Entities;
namespace Payers.Entities
{
    class Company : TaxPayer
    {

        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double TotalTax;
            if (NumberOfEmployees <= 10)
            {
                TotalTax = AnualIncome * 0.16;
            }
            else
            {
                TotalTax = AnualIncome * 0.14;
            }
            return TotalTax;
        }
    }
}