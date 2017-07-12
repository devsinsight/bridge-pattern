namespace bridge_pattern
{
    public abstract class Combo
    {
        protected readonly IDiscount discount;

        public Combo(IDiscount discount)
        {
            this.discount = discount;
        }

        abstract public void Print();

    }
}