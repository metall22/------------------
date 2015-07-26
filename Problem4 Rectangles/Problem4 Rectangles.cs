using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_Rectangles
{
    class Rectanlgearea
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rectangle width:");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter rectangle height");
            double height = double.Parse(Console.ReadLine());

            double perimeter = 2 * (width + height);
            double area = width * height;
            Console.WriteLine("Perimeter:"+perimeter);
            Console.WriteLine("Area:"+area);

        }
    }
}
