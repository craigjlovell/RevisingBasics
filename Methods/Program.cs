using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {            
            SayHello("Jordan", 18);
            SayHello("John", 18);
            SayHello("Josh", 17);
            SayHello("Dan", 18);


            Console.ReadLine();            
        }

        static void SayHello(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
}
