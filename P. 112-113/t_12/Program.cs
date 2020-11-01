using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many two digits numbers do you want to enter?");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("enter two digits number");
                int c = int.Parse(Console.ReadLine());
                int a = c / 10;
                int b = c % 10;
                if (a != b)
                {
                    Console.WriteLine("the number is {0} and the sum of the numbers is {1}", c, a + b);
                }
            }


        }
    }
}
