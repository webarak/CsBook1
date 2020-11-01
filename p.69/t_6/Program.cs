using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your first letter of your first name");
            char ch1 = char.Parse(Console.ReadLine());
            Console.WriteLine("please enter your first letter of your last name");
            char ch2 = char.Parse(Console.ReadLine());
            if (ch1 == ch2)
            {
                Console.WriteLine("your first name and your last name start with ths same letter");
            }
        }
    }
}
