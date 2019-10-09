using System;

namespace arithmeticoperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;
            /*
            Console.WriteLine("a + b = {0}", a + b);
            Console.WriteLine("a - b = {0}", a - b);
            Console.WriteLine("a * b = {0}", a * b);
            Console.WriteLine("a / b = {0}", a / b);
            Console.WriteLine("a % b = {0}", a % b);
             */
             //a = a + 2;
             //a += 1;
             //a++;
             //Console.WriteLine(a++);//10
             //Console.WriteLine(a);
             int c = a++;
             Console.WriteLine("c = "+c);
             Console.WriteLine("a = " + a);
             int d = --b;
             Console.WriteLine("B = "+ b);
             Console.WriteLine("d = "+ d);

        }
    }
}
