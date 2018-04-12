using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDEV117Assignment7A
{
    class Pizza
    {
        // Declarations
        private string toppings;
        private int diameter;
        private double price;

        public void setToppings(string extras)
        {
            toppings = extras;
        }

        public void setDiameter(int size)
        {
            diameter = size;
        }

        public void setPrice(double money)
        {
            price = money;
        }

        public string getToppings()
        {
            return toppings;
        }

        public int getDiameter()
        {
            return diameter;
        }

        public double getPrice()
        {
            return price;
        }
    }
}
