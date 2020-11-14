using System;

namespace Desing_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // var instance = new Singleton(); Error 'cause the constructor is private 
            Console.WriteLine(Singleton.Instance.message);
            Singleton.Instance.message = "Chao World";
            Console.WriteLine(Singleton.Instance.message);
        }

    }
}

