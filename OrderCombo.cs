using System;

namespace bridge_pattern
{
    public class OrderCombo : Order
    {
        public OrderCombo(ICombo combo, int quantity) : base(combo, quantity)
        {
        }

        public override void Print()
        {
            var discount = Combo.GetDiscount(Quantity);
            Console.WriteLine();
            Console.WriteLine(Combo.Name);
            Console.WriteLine("----------");
            Console.WriteLine("Description: {0}", Combo.Description);
            Console.WriteLine("Price: {0}", Combo.Price);
            Console.WriteLine("Quantity: {0}", Quantity);
            Console.WriteLine("Discount: {0}", discount);
            Console.WriteLine("--------------------");
            Console.WriteLine("Total: {0}", (Combo.Price * Quantity) - discount);
            Console.WriteLine();

        }
    }
}