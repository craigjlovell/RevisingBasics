﻿using System;

namespace GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "LOL");


            Console.WriteLine(avengers.title  +  avengers.Rating);
            Console.ReadLine();
        }
    }
}
