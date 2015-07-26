using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13_Check_a_Bit_at_Given_Position
{
    class CheckbitatGivenPosition
    {
        static void Main(string[] args)
        {
          int n =int.Parse(Console.ReadLine());
          int p = int.Parse(Console.ReadLine());
          bool isOne = (n & (1 << p)) > 0;
          Console.WriteLine(isOne);
        }
    }
}
