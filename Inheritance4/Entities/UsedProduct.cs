using System;
using Inheritance4.Entities;

namespace Inheritance4.Entities
{
    class UsedProduct : Product
    {
        public DateOnly ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateOnly manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + $"(Manufacture date: {ManufactureDate})";
        }

    }
}
