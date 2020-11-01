using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._82
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter another number");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 != num2)
            {
                if (num1 > num2)
                {
                    Console.WriteLine("the first number is bigger than the second one");
                    Console.WriteLine("{0}, {1}", num2, num1);
                }
                else
                {
                    Console.WriteLine("the second number is bigger than the first one");
                    Console.WriteLine("{0}, {1}", num1, num2);
                }

            }
            else
            {
                Console.WriteLine("the numbers {0} and {1} are equal",num1,num2);
            }
        }
    }
}
