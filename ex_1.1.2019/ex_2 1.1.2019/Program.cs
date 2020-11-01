using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1._1._2019
{
    class Program
    {
        public static double av3(double n1,double n2,double n3)
        {
            double b = (n1 + n2 + n3) / 3;
            return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("enter another number");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("enter another number");
            double c = double.Parse(Console.ReadLine());
            double avarage = av3(a, b, c);
            Console.WriteLine("the avarage of the numbers is {0:F2}", avarage);
        }
    }
}
