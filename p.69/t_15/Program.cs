using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your grade at the end of Simester A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter your grade at the end of Simester B");
            int B = int.Parse(Console.ReadLine());
            if (A < B)
            {
                Console.WriteLine("your final grade in this year is {0}", B * 0.9 + A * 0.1);
            }
            else
            {
                Console.WriteLine("your final grade in this year is {0}", (double)(B + A) / 2);
            }
        }
    }
}
