using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 19;
            string name = "Jay";
            string game = "MineCraft";

            Console.WriteLine($"There once was a special man named {name}"); // can also do - Console.WriteLine("There once was a special man named " + name);
            Console.WriteLine($"He was {age} years old");
            Console.WriteLine($"{name} really liked to play games such as {game}");
            Console.WriteLine($"But didn't like to lose");

            Console.ReadLine();
        }
    }
}
