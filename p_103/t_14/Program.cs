using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter 3 digits number");
            int x = int.Parse(Console.ReadLine());
            int M = x / 100;
            int A = (x % 100) / 10;
            int Y = x % 10;
            if ((Math.Pow(M, 30)) + (Math.Pow(A, 3)) + (Math.Pow(Y, 3)) == x)
            {
                Console.WriteLine("this number is triple number");
            }
            else
            {
                Console.WriteLine("this number isn't triple number");
            }
        }
    }
}
