using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int multiply = 1;
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter another number");
            int num1 = int.Parse(Console.ReadLine());
            multiply = num * num1;
            while (multiply != 0)
            {
                Console.WriteLine("multiply = {0}", multiply);
                sum = sum + multiply;
                Console.WriteLine("enter a number");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("enter another number");
                num1 = int.Parse(Console.ReadLine());
                multiply = num * num1;
            }
            if (sum < 0)
            {
                Console.WriteLine("the sum of the multiplations is {0} and its negetive", sum);
            }
            if (sum > 0)
            {
                Console.WriteLine("the sum of the multiplations is {0} and its positive", sum);
            }
        }
    }
}
