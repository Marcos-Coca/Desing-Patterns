using System;

namespace Desing_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrink drink = Factory.DrinkFactory(Factory.DrinkType.Wine);
            Console.WriteLine(drink.Taken());
        }

    }
}

