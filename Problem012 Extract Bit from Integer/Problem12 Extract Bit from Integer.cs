using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem012_Extract_Bit_from_doubleeger
{
    class BitFromint
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            uint mask = 1;

            if ((mask << p & number) == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("1");
            }
            



        }
    }
}
