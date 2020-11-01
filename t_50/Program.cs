using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            double num = double.Parse(Console.ReadLine());
            double max = num - (Math.Floor(num));
            for (int i = 2; i <=10; i++)
            {
                Console.WriteLine("enter another number");
                num = double.Parse(Console.ReadLine());
                double max1 = num - (Math.Floor(num));
                if (max1 > max)
                {
                    max = max1;
                }
            }
            Console.WriteLine(max);

        }
    }
}
