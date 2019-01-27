using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
           foreach( int n in Enumerable.Range(1, 100))
           {
                Console.WriteLine(n.FizzBuzz());
           }
           Console.WriteLine("Press any key to exit...");
           Console.ReadKey();
        }
    }
}
