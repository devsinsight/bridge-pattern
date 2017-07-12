namespace bridge_pattern
{
    public interface IDiscount
    {
         decimal GetDiscount(string name, decimal price, int quantity);
    }
}