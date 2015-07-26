using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11_Bitwise_Extract_Bit_3
{
    class BitwiseExtractBit3
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            uint mask = 1;

            if ((mask << 3 & number) == 0)
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
