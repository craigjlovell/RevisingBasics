using System;

namespace BuildingCalculatorINT
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = Convert.ToInt32("45"); //convert string to int

            Console.Write("Enter a number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a secend number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"answer =  {num1 + num2} ");
        }
    }
}
