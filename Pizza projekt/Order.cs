using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_projekt
{
    class Order
    {
        private Custommer _custommer;
        private Pizza _pizza;
        
        
        public Order(Pizza pizza, Custommer custommer)
        {
            _pizza = pizza;
            _custommer = custommer;
        }

        public Double CalculateTotalPrice()
        {
            const double delivery = 40;
            const double taxes = 1.20;
            double TotalPrice = _pizza.PizzaPrice * taxes + delivery;
            return TotalPrice;
        }
        public override string ToString()
        {
            return $"Order: {_pizza} - Custommer: {_custommer}";
        }
    }
}
