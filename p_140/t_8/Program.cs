using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("please enter number");
            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                count = count + 1;
                Console.WriteLine("please another enter number");
                num = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("the number of the positive number is {0}",count);
        }
    }
}
