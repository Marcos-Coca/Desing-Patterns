using System;

namespace Desing_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // var instance = new Singleton(); Error 'cause the constructor is private 
            Console.WriteLine(Singleton.Instance.message);
            Console.WriteLine(Singleton.Instance.message);
        }

    }
}

