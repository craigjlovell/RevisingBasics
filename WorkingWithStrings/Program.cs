using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Magic Academy" + " The best magic school around ";

            Console.WriteLine("Magic\nSchool"); // \n moves to line under
            Console.WriteLine(phrase); 
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("Academy"));
            Console.ReadLine();
        }
    }
}
