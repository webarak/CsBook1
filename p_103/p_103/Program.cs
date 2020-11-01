using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_103
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a lengh of triangle rib");
            int rib1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter a lengh of another triangle rib");
            int rib2 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter a lengh of another triangle rib");
            int rib3 = int.Parse(Console.ReadLine());
            int P = rib1 + rib2 + rib3;
            int P2 = P/2;
            double S = Math.Sqrt(P2 * (P2 - rib1) * (P2 - rib2) * (P2 - rib3));
            Console.WriteLine("the S of the tringale is {0:F2} and the P of the triangle is {1}", S, P);
        }
    }
}
