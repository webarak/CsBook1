using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._127
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            long multiply = 1;
            Console.WriteLine("enter the DOWN number");
            int down = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the UP number");
            int up = int.Parse(Console.ReadLine());
            for (int i = down; i <= up; i++)
            {
                sum = sum + i;
                multiply = multiply * i;
            }
            Console.WriteLine("the sum is {0} and the multiplation is {1}", sum, multiply);
        }
    }
}
