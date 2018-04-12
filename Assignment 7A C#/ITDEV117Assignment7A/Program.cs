using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDEV117Assignment7A
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza myPizza = new Pizza();
            Pizza yourPizza = new Pizza();

            myPizza.setToppings("Peperonni");
            myPizza.setDiameter(12);
            myPizza.setPrice(13.99);

            yourPizza.setToppings("Pineapple");
            yourPizza.setDiameter(14);
            yourPizza.setPrice(15.99);

            Console.WriteLine("Pizza 1 info: ");
            Console.WriteLine(myPizza.getToppings());
            Console.WriteLine(myPizza.getDiameter());
            Console.WriteLine(myPizza.getPrice());
            Console.WriteLine("");
            Console.WriteLine("Pizza 2 info: ");
            Console.WriteLine(yourPizza.getToppings());
            Console.WriteLine(yourPizza.getDiameter());
            Console.WriteLine(yourPizza.getPrice());
            Console.WriteLine("");
            Console.WriteLine("Press enter to exit...");
            Console.ReadKey();
        }
    }
}
