using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("I am a Tall Male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("i am male and short");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("i am not male and i am tall");
            }
            else
            {
                Console.WriteLine("I am not Male nor am i tall");
            }

            Console.ReadLine();
        }


    }
}
