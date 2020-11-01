using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_58
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i;
            for (i = 100; i <= 999; i++)
            {
                int A = i / 10 % 10;
                int M = i / 100;
                int Y = i % 10;
                if (i % (A + M + Y) == 0)
                {
                    sum = sum + 1;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
