using System;

namespace bridge_pattern
{
    public class SuperCombo : Combo
    {
        public SuperCombo(IDiscount discount) : base(discount)
        {
        }

        public override void Print()
        {
            Console.WriteLine("Super Combo");
            Console.WriteLine("-----------");
            Console.WriteLine("Price: $ {0}", discount.GetDiscount(Price, Quantity));
            Console.WriteLine();
        }
    }
}