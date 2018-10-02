using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class Program
    {
        static void Main(string[] args)
        {
           PlainPizza pizza = new PlainPizza();
            Console.WriteLine("Plain Pizza: " + pizza.GetPrice().ToString());

            HamDecorator moreHam = new HamDecorator(pizza);
            HamDecorator someMoreHam = new HamDecorator(moreHam);
            Console.WriteLine("Plain Pizza with double extra Ham: " + someMoreHam.GetPrice().ToString());

            BaconDecorator moreBacon = new BaconDecorator(someMoreHam);
            Console.WriteLine("Plain Pizza with double extra Ham with Bacon: " + moreBacon.GetPrice().ToString());

            PepperoniDecorator morePepperoni = new PepperoniDecorator(moreBacon);
            Console.WriteLine("Plain Pizza with double extra Ham with Bacon with Pepperoni: " + morePepperoni.GetPrice().ToString());

            Console.ReadLine();

        }
    }
    
}
