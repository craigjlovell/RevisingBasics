using System;

namespace _2dArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };
            //int[,] myArray = new int[2, 5];

            Console.WriteLine(numberGrid[1, 1]);

            Console.ReadLine();
        }
    }
}
