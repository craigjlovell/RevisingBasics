﻿using System;

namespace BuildinganExponentMethod
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(GetPow(3, 4));

            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for(int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }
    }
}