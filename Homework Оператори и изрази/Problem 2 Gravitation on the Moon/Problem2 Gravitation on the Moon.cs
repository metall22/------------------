using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Gravitation_on_the_Moon
{
    class MoonGravitation
    {
        static void Main(string[] args)
        {
            double weightOnEarth = double.Parse(Console.ReadLine());

            double weightOnTheMoon = weightOnEarth * (17/100f);

            Console.WriteLine("Your weight on Earth is: "+weightOnEarth);
            Console.WriteLine("Your weight on the moon is{0:0.00}",weightOnTheMoon);

        }
    }
}
