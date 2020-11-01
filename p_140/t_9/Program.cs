using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = int.MaxValue;
            Console.WriteLine("enter the first grade");
            int num = int.Parse(Console.ReadLine());
            while (num >= 0)
            {
                if (max < num)
                {
                    max = num;
                }
                if (min > num)
                {
                    min = num;
                }
                if (num >= 95)
                {
                    Console.WriteLine("pass good");
                }
                if (num < 55)
                {
                    Console.WriteLine("fail");
                }
                Console.WriteLine("enter another grade");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the biggest grade is {0}", max);
            Console.WriteLine("the lowest grade is {0}", min);
        }
    }
}
