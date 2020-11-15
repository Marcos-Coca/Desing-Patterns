using System;
using System.Collections.Generic;
using System.Text;

namespace Desing_Patterns
{
    interface IWidgetFactory
    {
        string CreateScrollBar();
        string CreateWindow();

    }

    class AndroidWidget : IWidgetFactory
    {
        public string CreateScrollBar()
        {
            return "Scroll Bar for Android Devices";
        }

        public string CreateWindow()
        {
            return "Window for Android Devices";
        }
    }

    class IPhoneWidget : IWidgetFactory
    {
        public string CreateScrollBar()
        {
            return "Scroll Bar for IPhone Devices";
        }

        public string CreateWindow()
        {
            return "Window for IPhone Devices";
        }
    }
}
