using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._146
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter a 1 digit number");
            int num1 = int.Parse(Console.ReadLine());
            bool apiriance = false;
            while (num != 0)
            {
                if (num % 10 == num1)
                    apiriance = true;
                num = num / 10;
            }
            Console.WriteLine(apiriance);
        }
    }
}
