using System;

namespace StaticMethodsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Math.Sqrt(144)); dont need anymore leaving for keep sake

           // UsefulTools tools = new UsefulTools(); //error caused by making it static in the class 

            UsefulTools.SayHi("Craig");

            Console.ReadLine();
        }
    }
}
