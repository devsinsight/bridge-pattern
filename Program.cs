using System;
using System.Collections.Generic;

namespace bridge_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Combo> combos = new List<Combo>();
            var thirtyPercentDiscount = new ThirtyPercentDiscount();
            var twentyPercentDiscount = new ThirtyPercentDiscount();

            var simpleCombo = new SimpleCombo(thirtyPercentDiscount){
                Price = 50.0M,
                Quantity = 4
            };

            combos.Add(simpleCombo);

            var superCombo = new SuperCombo(twentyPercentDiscount){
                Price = 80.0M,
                Quantity = 4
            };

            combos.Add(superCombo);

            foreach(var combo in combos)
            {
                combo.Print();
            };

        }
    }
}
