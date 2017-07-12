namespace bridge_pattern
{
    public class ThirtyPercentDiscount : IDiscount
    {
        public decimal GetDiscount(decimal price, int quantity)
        {
            return price > 10.0M && quantity > 3 ? discount(price) : price;
        }

        private decimal discount(decimal price) => price / 1.3M;
    }
}