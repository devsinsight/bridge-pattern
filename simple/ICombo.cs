namespace bridge_pattern.simple
{
    public interface ICombo
    {
        string Name { get; set; }
        decimal Price { get; set; }
        string Description { get; set; }
        decimal GetDiscount(int quantity);
        void SomethingElse();
    }
}