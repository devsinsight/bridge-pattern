using System;
using System.Collections.Generic;

namespace bridge_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting combos
            var simpleCombo = new SimpleCombo(9.99M, "Two pieces of fried chicken, fried potatos and soda.");
            var superCombo = new SuperCombo(29.50m, "Three pieces of fried chicken, fried potatos and extra large soda.");

            List<Order> orders = new List<Order>();

            //order!
            var orderSimpleCombo = new OrderCombo(simpleCombo, 3);
            var orderSuperCombo = new OrderCombo(superCombo, 1);

            orders.Add(orderSimpleCombo);
            orders.Add(orderSuperCombo);

            //results
            foreach(var order in orders)
            {
                order.Print();
            }
        }
    }
}
