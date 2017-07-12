namespace bridge_pattern
{
    public abstract class Combo
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        protected readonly IDiscount discount;

        public Combo(IDiscount discount)
        {
            this.discount = discount;
        }

        abstract public void Print();

    }
}