using System;

namespace BuildingaGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretWord = "Magic";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter Word guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                    //Console.WriteLine("Wrong Guess Again");
                    
                }
                else
                {
                    outOfGuesses = true;
                }


            }
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose");
            }
            else
            {
                Console.WriteLine("Dam you got the word good job");
                Console.WriteLine("you win");
            }

            Console.ReadLine();
        }
    }
}
