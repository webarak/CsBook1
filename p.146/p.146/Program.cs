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
            int count = 0;
            while (num != 0)
            {
                count = count + 1;
                num = num / 10;
            }
            Console.WriteLine("the number of the numbers in the number is {0}", count);
        }
    }
}
