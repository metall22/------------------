using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14_Modify_a_Bit_at_Given_Position
{
    class ModifyBitatPosition
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            int mask = 1;

            if (v == 0)
            {
                n = n & ~(mask<< p);
                
            }
          
            else
            {
                n = n | (mask << p);
            }
            Console.WriteLine(n);
        }
    }
}
