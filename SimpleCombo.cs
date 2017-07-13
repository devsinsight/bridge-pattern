using System;

namespace bridge_pattern
{
    public class SimpleCombo : Combo   
    {
        public SimpleCombo(decimal price, string description) : base(nameof(SimpleCombo), price, description)
        {
        }

        public override decimal GetDiscount(int quantity)
        {
            return quantity > 2 ? Price * quantity * 0.3M : 0;
        }
    }
}