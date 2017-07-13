namespace bridge_pattern
{
    public interface IOrder
    {
        int Quantity { get; set; }
         void Print();
    }
}