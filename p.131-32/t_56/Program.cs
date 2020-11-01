using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_56
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("enter 3 digits number");
                int num = int.Parse(Console.ReadLine());
                int A = num / 10 % 10;
                int M = num / 100;
                int Y = num % 10;
                if ((A == M) || (A == Y) || (M == Y))
                {
                    Console.WriteLine("the number {0} has at list 2 similar digits", num);
                    sum = sum + 1;
                }
            }
            Console.WriteLine("{0} numbers have at list 2 similar digits", sum);
        }
    }
}
