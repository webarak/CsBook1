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
            Console.WriteLine("enter positive number");
            int num = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 1;
            int p3 = 0;
            Console.Write(p1);
            while (p2 < num)
            {
                  
                p3 = p1;
                p1 = p2;
                p2 = p3 + p1;
                Console.Write( ", " +p1);
                
            }
            Console.WriteLine();

        }
    }
}
