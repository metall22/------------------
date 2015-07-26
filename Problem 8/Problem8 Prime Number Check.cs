using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8
{
    class PrimeNUmberCheck
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (n >= 1)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                    }
                    

                }
                Console.WriteLine(isPrime);
            }
            else 
            {
                Console.WriteLine("False");
            }
        }
    }
}
