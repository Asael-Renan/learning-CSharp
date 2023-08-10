using Payers.Entities;

namespace Payers.Entities
{
    class Individual : TaxPayer
    {
        public double HealtExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healtExpenditures) : base(name, anualIncome)
        {
            HealtExpenditures = healtExpenditures;
        }

        public override double Tax()
        {
            double TotalTax;
            if (AnualIncome < 20000)
            {
                TotalTax = AnualIncome * 0.15;
            }
            else
            {
                TotalTax = AnualIncome * 0.25;
            }

            if (HealtExpenditures > 0)
            {
                TotalTax -= HealtExpenditures * 0.5;
            }

            return TotalTax;
        }
    }
}