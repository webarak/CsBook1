using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._69
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter another number");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("{0}, {1}", num2, num1);
                Console.WriteLine("{0}, {1}", num1, num2);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("{0}, {1}", num1, num2);
                Console.WriteLine("{0}, {1}", num2, num1);
            }
        }
    }
}
