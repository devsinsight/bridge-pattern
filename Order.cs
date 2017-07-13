using System;

namespace bridge_pattern
{
    public abstract class Order
    {
        protected readonly ICombo Combo;
        public int Quantity { get; set; }
        public Order(ICombo combo, int quantity){
            
            Combo = combo;
            Quantity = quantity;
        }

        public abstract void Print();
        
    }
}