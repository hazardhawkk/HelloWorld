using System;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO HAZARKHAWKK RESTAURANT");
            Console.WriteLine("MENU");
            Console.WriteLine("Foods: egg, cheese, lobster");
            Console.WriteLine("Drinks: egg yolks, milk, mayo");

            Console.Write("Choose a food from our menu:");
            string food = Console.ReadLine();
            if (food != "egg" && food != "cheese" && food != "lobster")
            {
                Console.WriteLine("Invalid, banned from restaurant.");
            }
            else
            {
                Console.Write("Choose a drink from our menu:");
                string drink = Console.ReadLine();
                if (drink != "egg yolks" && drink != "milk" && drink != "mayo")
                {
                    Console.WriteLine("Invalid, banned from restaurant.");
                }
                else
                {
                    Console.WriteLine("The cook is making " + food + " for you.");
                    Console.WriteLine("They are also making " + drink + " for you");
                }
            }
        }
    }
}
