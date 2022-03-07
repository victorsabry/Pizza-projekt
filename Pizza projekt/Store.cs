using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_projekt
{
    class Store
    {
        public void start()
        {
            //All pizzas being made
            var p1 = new Pizza("Large", "Pepperoni", "Cheese and pepperoni", 67);
            var p2 = new Pizza("Small", "Olympia", "Ham and bacon with onion and eggs", 78);
            var p3 = new Pizza("Medium", "Hawaii", "Ham and pinapple", 67);
           
            //All the customers
            var c1 = new Custommer("Victor", 22250850, "Bøgehegnet 165");
            var c2 = new Custommer("Line", 43506350, "Snebærhegnet 56");
            var c3 = new Custommer("Clara", 50509407, "Fyrrehegnet 42");

            //All the orders containing the pizzas and custommers
            var o1 = new Order(p1, c1);
            var o2 = new Order(p2, c2);
            var o3 = new Order(p3, c3);

            Console.WriteLine("Big Mamma Gastronomia");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("First order:");
            Console.WriteLine($"{o1}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Second order:");
            Console.WriteLine($"{o2}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Third order:");
            Console.WriteLine($"{o3}");
        }
    }
}
