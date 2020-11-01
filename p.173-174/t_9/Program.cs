using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_9
{
    class Program
    {
        public static int same(int num1, int num2)
        {
            int i = 2;
            int a = -1;
            bool yes = false;
            while (i <= Math.Min(num1, num2) && yes == true)
            {
                if ((num1%i ==0) && (num2%i==0))
                {
                    a = i;
                    yes = true;
                }
                i++;
            }
            
            return a;
        }
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("enter a number");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("enter another number");
                int b = int.Parse(Console.ReadLine());
                int c = same(a, b);
                if (c != -1)
                {
                    count = count + 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
