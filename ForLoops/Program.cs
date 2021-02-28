using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            //int i = 1;
            //
            //while(i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            int[] luckyNumbers = { 1, 23, 43, 34, 75, 56, 67, 58, 89, 710 };
            
            for(int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            Console.ReadLine();
        }
    }
}
