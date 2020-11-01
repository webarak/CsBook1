using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter from where you want to start");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter from where you want to over");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
