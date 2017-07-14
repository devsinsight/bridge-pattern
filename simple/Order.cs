using System;

namespace bridge_pattern.simple
{
    public class Order : ICombo
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public decimal GetDiscount(int quantity)
        {
            return 99;
        }

        public void SomethingElse(){
            //do something
        }
    }
}