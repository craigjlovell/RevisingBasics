using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeSalad();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();

            //Chef chef = new Chef();
            chef.MakeSpecial();

            //ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecial();



            Console.ReadLine();
        }

    }
}
