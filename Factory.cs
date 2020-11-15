using System;
using System.Collections.Generic;
using System.Text;

namespace Desing_Patterns
{
    public class Factory
    {
        public const int WINE = 1;
        public const int SODA = 2;
        public static Drink DrinkFactory(int type)
        {
            switch(type)
            {
                case WINE:
                    return new Wine();

                case SODA:
                    return new Soda();

                default: return null;
            }
        }
    }
    public abstract class Drink
    {
        public abstract int Taken();
    } 

    public class Wine : Drink
    {
        public override int Taken()
        {
            return 20;
        }
    }

    public class Soda : Drink
    {
        public override int Taken()
        {
            return 50;
        }
    }
}
