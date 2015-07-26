using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_Third_Digit_is_7
{
    class ThirdDigtis7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number");
           int n= int.Parse(Console.ReadLine());
           

           if (n /100 %10== 7)
           {
               Console.WriteLine("True");
           }
           else
           {
               Console.WriteLine("False");
           }
        }
    }
}
