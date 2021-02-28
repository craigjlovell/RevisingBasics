using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class ItalianChef : Chef
    {
        public void MakesPasta()
        {
            Console.WriteLine("MakesPasta");
        }
        public void MakesPizza()
        {
            Console.WriteLine("MakesPizza");
        }
        public void MakesGarlicBread()
        {
            Console.WriteLine("MakesGarlicBread");
        }
        public override void MakeSpecial()
        {
            Console.WriteLine("Makes a Amazing fresh made Italian five course meal");
        }

    }
}
