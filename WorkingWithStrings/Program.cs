using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Magic Academy" + " The best magic school around ";
            //               01234

            Console.WriteLine("Magic\nSchool"); // \n moves to line under
            Console.WriteLine(phrase); 
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("Academy"));
            Console.WriteLine(phrase.Contains("Dogs")); //if word dog is in the sentence true if not false
            Console.WriteLine(phrase[3]); //whats in [3] letter shows / number
            Console.WriteLine(phrase.IndexOf("Academy")); //shows loacation of the start of the word or location of letter
            Console.WriteLine(phrase.Substring(14)); // will start printing from number 14 []
            Console.WriteLine(phrase.Substring(phrase.IndexOf("magic")));
            Console.ReadLine();
        }
    }
}
