using System;

namespace bridge_pattern
{
    public abstract class Combo
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Combo(string name, decimal price, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;

        }

        public abstract decimal GetDiscount(int quantity);
    }
}