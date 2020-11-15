using System;

namespace Desing_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            User roberto = new UserBuilder(4, "Roberto").Age(15).FamilyName("Perez").Build();
            User marcos = new UserBuilder(1, "Marcos").FamilyName("Coca").Profession("Developer").Build();

            User[] users = new User[] { marcos, roberto };


            foreach(User user in users)
            {
                Console.WriteLine($"Id: {user.Id} Name: {user.Name} Family Name: {user.FamilyName} Age: {user.Age} Profession: {user.Profession}");
            }
        }

    }
}

