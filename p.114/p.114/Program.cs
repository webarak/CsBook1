using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._114
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("enter 3 digits number");
                int num = int.Parse(Console.ReadLine());
                int m = num / 100;
                int a = (num / 10) % 10;
                int y = num % 10;
                if (m != a && m != y && a != y)
                    Console.WriteLine("{0}", num);
            }
        }
    }
}
