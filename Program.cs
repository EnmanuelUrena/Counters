using System;
using System.Collections.Generic;

namespace CounterFinal
{
    class Program
    {
        private static IEnumerable<int> NaturalCounter()
        {

            for (int i = 1; i <= 10; i++)
            {
                yield return i;
            }
        }
        private static IEnumerable<int> FibonacciCounter()
        {
            int a = 1, b = 0, c = 0;
            for (int i = 0; i < 10; i++)
            {
                c = a;
                a = b;
                b = c + a;
                yield return a;
            }
        }
        private static IEnumerable<int> PrimoCounter()
        {
            for (int i = 1; i < 10; i++)
            {
                if (i == 2)
                {
                    yield return i;
                }
                if (i % 2 != 0)
                {
                   yield return i; 
                }
            }
        }

        static void Main(string[] args)
        {
           System.Console.WriteLine("Naturales:"); 
           foreach (var item in NaturalCounter())
           {
               System.Console.WriteLine(item);
           }
           System.Console.WriteLine("Fibonacci:");
           foreach (var item in FibonacciCounter())
           {
               System.Console.WriteLine(item);
           }
           System.Console.WriteLine("Primos:");
           foreach (var item in PrimoCounter())
           {
               System.Console.WriteLine(item);
           }

        }
    }
}
