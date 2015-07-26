using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7_Point_in_a_Circle
{
    class PoininCircle
    {
        static void Main(string[] args)
        {
            double x=double.Parse(Console.ReadLine());
            double y =double.Parse(Console.ReadLine());
            bool inCircle=(((x*x)+(y*y))<=2*2);
            Console.WriteLine(inCircle);
        }
    }
}
