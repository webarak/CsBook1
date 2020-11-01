using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter 3 digits number");
            int num = int.Parse(Console.ReadLine());
            int Yehidot = num % 10;
            int Meot = num / 100;
            if (Yehidot == Meot)
            {
                Console.WriteLine("this number is a palindrom");
            }
            else
            {
                Console.WriteLine("this number is not a palindrom");
            }
        }
    }
}
