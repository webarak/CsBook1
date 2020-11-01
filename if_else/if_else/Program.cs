using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("the number is an odd number");
            }
        }
    }
}
