using System;

namespace Desing_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink drink = Factory.DrinkFactory(Factory.SODA);
            Console.WriteLine(drink.Taken());
        }

    }
}

