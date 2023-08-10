namespace Inheritance3.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdicionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string? name, int hours, double valuePerHour, double adicionalCharge)
        : base(name, hours, valuePerHour)
        {
            AdicionalCharge = adicionalCharge;
        }

        public override double Payment()
        {
            double Payment = base.Payment() + AdicionalCharge + (AdicionalCharge * 0.1);
            return Payment;
        }
    }
}