using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Divide_by_7_and_5
{
    class Divideby5and7
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Boolean DividedBy7and5 =( n % 5==0) && (n % 7==0 );
            Console.WriteLine(DividedBy7and5);
        }
    }
}
