using System;
using Pizzeria;
using Workshop;

namespace Trabalho4
{
    class Program
    {
        static void Main(string[] args)
        {
            AmericanRestaurant americanRestaurant = new AmericanRestaurant(new PepperoniPizza());
            americanRestaurant.Deliver();

            ItalianRestaurant italianRestaurant = new ItalianRestaurant(new VeggiePizza());
            italianRestaurant.Deliver();

            CPUAMD CPU_AMD = new CPUAMD(new AMD());
            CPU_AMD.Mount();
            CPUIntel CPU_Intel = new CPUIntel(new Intel());
            CPU_Intel.Mount();
            
            Console.ReadKey();
        }
    }
}
