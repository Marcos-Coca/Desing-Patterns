using System;
using System.Collections.Generic;
using System.Text;

namespace Desing_Patterns
{
    public class Singleton
    {
        private static Singleton instance = null;
        public string message = "";

        private Singleton() {
            this.message = "Hello World";
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
            }
        }
    }
}
