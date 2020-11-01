using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._146
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            double num = double.Parse(Console.ReadLine());
            int num1 = (int)(num);
            int count = 0;
            if (num1 == 0)
            {
                count = 1;
            }
            while (num1 != 0)
            {
                count = count + 1;
                num1 = num1 / 10;
            }
            Console.WriteLine("the number of the numbers before the dot in the number is {0}", count);
        }
    }
}
