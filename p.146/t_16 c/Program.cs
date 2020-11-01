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
            int num = int.Parse(Console.ReadLine());
            int multiply = 1;
            while (num != 0)
            {
                multiply = multiply * (num % 10);
                num = num / 10;
            }
            Console.WriteLine("the multiplation of the numbers in the number is {0}", multiply);
        }
    }
}
