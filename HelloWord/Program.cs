using System;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favourite food");
            string food = Console.ReadLine();
            Console.WriteLine("Enter your favourite drink");
            string drink = Console.ReadLine();
            Console.WriteLine("The cook is making " + food + " for you.");
            Console.WriteLine("They are also making " + drink + " for you");
        }
    }
}
