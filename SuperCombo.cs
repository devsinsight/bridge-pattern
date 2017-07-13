namespace bridge_pattern
{
    public class SuperCombo : Combo
    {
        public SuperCombo(decimal price, string description) : base(nameof(SuperCombo), price, description)
        {
        }

        public override decimal GetDiscount(int quantity)
        {
            return quantity > 3 ? Price * quantity * 0.2M : 0;
        }
    }
}