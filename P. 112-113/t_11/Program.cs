using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_11
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= 20; i++)
            {
                if (i % 4 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
