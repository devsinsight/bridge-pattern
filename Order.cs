using System;

namespace bridge_pattern
{
    public abstract class Order : IOrder
    {
        public int Quantity { get; set; }
        public Order(int quantity){
            
            Quantity = quantity;
        }

        public abstract void Print();
        
    }
}