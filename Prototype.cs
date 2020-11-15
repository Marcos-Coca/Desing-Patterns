using System;
using System.Collections.Generic;
using System.Text;

namespace Desing_Patterns
{
    public class Animal: ICloneable
    {
       public int Legs { get; set; }
       public string Name { get; set; }
        public Details Features { get; set;}

        public object Clone()
        {
            Animal clon = this.MemberwiseClone() as Animal;
            Details deatails = new Details();
            deatails.Color = this.Features.Color;
            deatails.Color = this.Features.Breed;
            clon.Features = deatails;
            return clon;
        }
    }

    public class Details
    {
        public string Color { get; set; }
        public string Breed { get; set; }
    }
}
