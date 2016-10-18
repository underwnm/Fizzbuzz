using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzbuzzProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Fizzbuzz current = new Fizzbuzz();
            current.PrintZeroToOneHundred();

            Console.ReadKey();
        }
    }
}
