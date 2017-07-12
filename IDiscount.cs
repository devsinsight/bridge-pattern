namespace bridge_pattern
{
    public interface IDiscount
    {
         decimal GetDiscount(decimal price, int quantity);
    }
}