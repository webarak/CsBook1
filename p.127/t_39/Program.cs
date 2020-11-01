using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_39
{
    class Program
    {
        static void Main(string[] args)
        {
            long multiply = 1;
            Console.WriteLine("enter a number that you want to do him Atheret");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                multiply = multiply * i;
            }
            Console.WriteLine(multiply);
        }
    }
}
