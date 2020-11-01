using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int num1 = 0;
            int sum = 0;
            while (sum != 7)
            {
                int y = num % 10;
                int a = num / 10;
                if (a + y == 7)
                {
                    num1 = num;
                    sum = 7;
                }
                num = num + 1;
            }
            Console.WriteLine(num1);
        }
    }
}
