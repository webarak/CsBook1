using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._78
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int num = int.Parse(Console.ReadLine());
            if ((num > -10) && (num < 10))
            {
                Console.WriteLine("this number is a one digit number");
            }
            else
            {
                Console.WriteLine("this number isn't a one digit number");
            }

        }
    }
}
