using System;
using System.Collections.Generic;
using System.Text;

namespace Desing_Patterns
{

    public interface IDrink
    {
        public int Taken();
    }
    public class Factory
    {
        public enum DrinkType
        {
            Wine,
            Soda
        }

        public static IDrink DrinkFactory(DrinkType drink)
        {
            switch(drink)
            {
                case DrinkType.Wine:
                    return new Wine();

                case DrinkType.Soda:
                    return new Soda();

                default: return null;
            }
        }
    }
    public class Wine : IDrink
    {
        public int Taken()
        {
            return 20;
        }
    }

    public class Soda : IDrink
    {
        public int Taken()
        {
            return 50;
        }
    }
}
