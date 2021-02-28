using System;

namespace BuildingCalculatorDOUBLE
{
    class Program
    {
        static void Main(string[] args)
        {           

            Console.Write("Enter a number :");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a secend number :");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"answer =  {num1 + num2} ");
        }
    }
}
