using System;

namespace Desing_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal() {Name="Dolly",Legs=4};
            animal.Features = new Details() {Color="White",Breed="Sheep" };

            Animal clonedAnimal = animal.Clone() as Animal;
            clonedAnimal.Features = new Details() { Color = "Black", Breed = "Black Sheep" };

            Console.WriteLine("Original Animal"+animal.Features.Color);
            Console.WriteLine("Cloned Animal"+animal.Features.Color);
            Console.WriteLine("Original Animal"+animal.Features.Breed);
            Console.WriteLine("Cloned Animal"+animal.Features.Breed);
        }

    }
}

