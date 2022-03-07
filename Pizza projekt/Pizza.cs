using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_projekt
{
    class Pizza
    {
        private string _pizzaName;
        private string _pizzaTopping;
        private int _pizzaPrice;
        public string Størrelse { get; }
        public Pizza(string størrelse, string name, string topping, int price)
        {
            _pizzaName = name;
            _pizzaTopping = topping;
            _pizzaPrice = price;
            Størrelse = størrelse;
        }
        public int PizzaPrice
        {
            get { return _pizzaPrice; }
        }
        public string PizzaName
        {
            get { return _pizzaName; }
        }
        public string PizzaTopping
        {
            get { return _pizzaTopping; }
        }
        public override string ToString()
        {
            return $"Size: {Størrelse} - Pizza: {PizzaName} - Topping: {PizzaTopping} - Price: {PizzaPrice}";
        }
    }
}
