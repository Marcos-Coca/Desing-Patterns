using System;

namespace Desing_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            UseWidget(new AndroidWidget());
            UseWidget(new IPhoneWidget());
        }

        static void UseWidget(IWidgetFactory widget)
        {
            Console.WriteLine(widget.CreateScrollBar());
            Console.WriteLine(widget.CreateWindow());
        }

    }
}

