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
            Console.WriteLine("please enter 2 digits number");
            int num2 = int.Parse(Console.ReadLine());
            int Ahadot = num2 % 10;
            int num3 = Ahadot * 100 + num2;
            Console.WriteLine("the new number is : {0}", num3);
        }
    }
}
