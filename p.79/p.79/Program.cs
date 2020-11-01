using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._79
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter another number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter anotehr number");
            int num3 = int.Parse(Console.ReadLine());
            if ((num1 + num2 > num3) && (num3 + num2 > num1) && (num1 + num3 > num2))
            {
                Console.WriteLine("this numbers can be the leangh of tringale ribs");
            }
            else
            {
                Console.WriteLine("this numbers can't be the leangh of tringale ribs");
            }
       
        }
    }
}
