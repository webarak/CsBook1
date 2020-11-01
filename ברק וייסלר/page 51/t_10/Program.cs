using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("the 3 following numbers are : {0}, {1}, {2}", num + 1, num + 2, num + 3);
        }
    }
}
