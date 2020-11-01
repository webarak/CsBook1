using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_1._1._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int big = -1;
            int num1 = 0;
            int sum1 = 0;
            Console.WriteLine("enter positive number");
            int num = int.Parse(Console.ReadLine());
            while (num != -999)   
            {
                num1 = num;
                sum = 0;
                while (num != 0)
                {
                    sum = sum + (num%10);
                    num = num / 10;
                }
                if (sum > sum1)
                {
                    sum1 = sum;
                    big = num1;
                }
                Console.WriteLine("enter another positive number");
                num = int.Parse(Console.ReadLine());
               
            }
            Console.WriteLine("the number with the biggest numbers sum is {0}", big);
        }
    }
}
