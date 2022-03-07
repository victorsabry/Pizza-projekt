using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_projekt
{
    class Store
    {
        public void start()
        {
            var p1 = new Pizza("Large", "Pepperoni", "Cheese and pepperoni", 67);
            var p2 = new Pizza("Small", "Olympia", "Ham and bacon with onion and eggs", 78);
            var p3 = new Pizza("Medium", "Hawaii", "Ham and pinapple", 67);

           

            var c1 = new Custommer("Victor", 22250850, "Bøgehegnet 165");
            var c2 = new Custommer("V", 22222222, "Snebærhegnet 56");
            var c3 = new Custommer("C", 88888888, "Fyrrehegnet 41");

            var o1 = new Order(p1, c1);
            var o2 = new Order(p2, c2);
            var o3 = new Order(p3, c3);
        }
    }
}
