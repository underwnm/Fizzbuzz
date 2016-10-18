using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzbuzzProgram
{
    class Fizzbuzz
    {

        public void PrintZeroToOneHundred()
        {
            for (int i = 0; i <= 100; i++)
            {
                string output;
                bool CanBeDividedByThree = CanBeDividedBy(i, 3);
                bool CanBeDividedByFive = CanBeDividedBy(i, 5);

                if (CanBeDividedByFive && CanBeDividedByThree)
                {
                    output = "fizzbuzz";
                } else if (CanBeDividedByThree)
                {
                    output = "fizz";
                } else if (CanBeDividedByFive)
                {
                    output = "buzz";
                } else
                {
                    output = i.ToString();
                }
                Console.WriteLine(output);
            }
        }
        public bool CanBeDividedBy(int indexNumber, int targetNumber)
        {
            return (indexNumber % targetNumber) == 0;
        }
    }
}
