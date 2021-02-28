using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("Makes Chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("Makes Salad");
        }
        public virtual void MakeSpecial()
        {
            Console.WriteLine("Makes Amazing BBQ Ribs");
        }
    }
}
