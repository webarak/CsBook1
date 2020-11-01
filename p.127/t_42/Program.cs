using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_42
{
    class Program
    {
        static void Main(string[] args)
        {
            double avarage = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("enter a number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter another number");
                int num2 = int.Parse(Console.ReadLine());
                if (num1 > num2)
                {
                    avarage = avarage + num1;
                }
                else if (num2 > num1)
                {
                    avarage = avarage + num2;
                }
            }
            Console.WriteLine("the avarage of the big numbers in the couples is {0}", avarage/20);
        }
    }
}
