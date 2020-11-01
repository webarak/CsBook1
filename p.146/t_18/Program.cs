using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            int count = 0;
            int same = 0;
            while (same < 5)
            {
                count = count + 1;
                int num1 = R.Next(1, 7);
                int num2 = R.Next(1, 7);
                if (num1 == num2)
                {
                    same = same + 1;
                    Console.WriteLine("***********");
                }
                Console.WriteLine("the first cube number is {0} and the second cube number is {1}", num1, num2);
            }
            Console.WriteLine("the cubes trowed {0} times", count);
        }
    }
}
