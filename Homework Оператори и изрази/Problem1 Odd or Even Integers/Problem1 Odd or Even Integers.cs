using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_Odd_or_Even_Integers
{
    class OddEven
    {
        static void Main(string[] args)

        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("False",n);
            }

            else if (n % 2 != 0)
            {
                Console.WriteLine("True",n);
            }
        }
    }
}
