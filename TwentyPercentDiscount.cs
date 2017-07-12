using System;

namespace bridge_pattern
{
    public class TwentyPercentDiscount : IDiscount
    {
        public decimal GetDiscount(decimal price, int quantity)
        {
            return price > 8.0M && quantity > 2 ? discount(price) : price;
        }

        private decimal discount(decimal price) => price / 1.2M;
    }
}