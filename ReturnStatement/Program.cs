using System;

namespace ReturnStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubeNumber = Cube(5);
            Console.WriteLine(cubeNumber);


            Console.ReadLine();
        }

        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }

    }
}
