using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 1, 6, 7, 10, 14, 11, 17, 19, 22 }; //[9]
                                // 0, 1, 2, 3,  4,   5,  6,  7,  8
            // luckyNumbers[i] = number; "can force a spot to be a specific number even if its not the same in the []"

            string[] friends = new string[9];
            friends[0] = "Craig";
            friends[1] = "Jordan";

            

            Console.WriteLine(luckyNumbers[4]);

            Console.WriteLine(friends[1]);


            Console.ReadLine();
        }
    }
}
