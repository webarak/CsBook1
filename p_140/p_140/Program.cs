using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_140
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            Console.WriteLine("please enter 2 digits number");
            int num = int.Parse(Console.ReadLine());
            while (num >= 10 && num<=99)
            {
                int A = num / 10;
                int Y = num % 10;
                if (A != Y)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }
                Console.WriteLine("enter another number");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the biggest number with 2 different digits is {0}", max);
        }
    }
}
