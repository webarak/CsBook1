using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the radius of a circle");
            double r = double.Parse(Console.ReadLine());
            double k = r * 2;
            double p = 2 * r * Math.PI;
            double s = Math.Pow(r, 2) * Math.PI;
            Console.WriteLine("the koter of the cercle is {0}, the P of the circle is {1:F2} and the S of the circle is {2:F2}", k, p, s);

        }
    }
}
