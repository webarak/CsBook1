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
            int count = 0;
            while (num != 0)
            {
                sum = sum + 1;
                if (num % 10 == num1)
                {
                    count = sum;
                }
                num = num / 10;
            }
            Console.WriteLine("the place of the number {0}  is {1}", num1, count);

        }
    }
}
