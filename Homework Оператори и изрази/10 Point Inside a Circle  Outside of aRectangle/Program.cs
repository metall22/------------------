using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Point_Inside_a_Circle__Outside_of_aRectangle
{
    class PoinCicleReactangle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool inCircle = (((Math.Pow ( x-1,2) + (Math.Pow ( y-1,2)) <= 1.5 * 1.5)));
            bool inRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);

            if (inCircle && !inRectangle)
            {
                Console.WriteLine("YES");
            }
            else 
            {
                Console.WriteLine("No");
            }
        }
    }
}
