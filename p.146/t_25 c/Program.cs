using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int p1 = 0;
            int p2 = 1;
            int p3 = 0;
            Console.Write(p1);
            while (sum < 120)
            {

                p3 = p1;
                p1 = p2;
                p2 = p3 + p1;
                Console.Write(", " + p1);
                sum = sum + p2;

            }
            Console.WriteLine();
            

        }
    }
}
