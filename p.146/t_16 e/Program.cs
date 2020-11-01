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
            Console.WriteLine("please enter a 1 digit number");
            int num1 = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num != 0)
            {
                if (num % 10 == num1)
                    sum = sum + 1;
                num = num / 10;
            }
            Console.WriteLine("the number {0} is showing {1} times in {2}", num1, sum, num);
        }
    }
}
