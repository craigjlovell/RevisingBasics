using System;

namespace GettingUserImput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name} its Nice to meet you how old are you");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age + " Years old ");

            Console.ReadLine();

        }
    }
}
