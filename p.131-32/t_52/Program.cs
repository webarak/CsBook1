using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_52
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.MaxValue;
            int z = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("enter a number");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("enter another number");
                int num1 = int.Parse(Console.ReadLine());
                if (num1 < num)
                {
                    if (y > num)
                    {
                        y = num;
                        z = i;
                    }

                }
                else if (num1 < num)
                {
                    if (y > num1)
                    {
                        y = num1;
                        z = i;
                    }

                }
                
            }
            Console.WriteLine("the lowest number from the bigger numbers is {0} and he is the  {1} number", y, z);
        }
    }
}
