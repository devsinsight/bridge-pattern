using System;

namespace bridge_pattern
{
    public class SimpleCombo : Combo
    {
        public SimpleCombo(IDiscount discount) : base(discount)
        {
        }

        public override void Print()
        {
            Console.WriteLine("Simple Combo");
            Console.WriteLine("------------");
            Console.WriteLine("Price: $ {0}", discount.GetDiscount(Price, Quantity));
            Console.WriteLine();
        }
    }
}