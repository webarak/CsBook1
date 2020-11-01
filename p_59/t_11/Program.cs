using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter 3 digits number");
            int num = int.Parse(Console.ReadLine());
            if ((num / 100 > 0) && (num / 100 < 10))
            {
                int Ahadot = num % 10;
                int Asarot = (num % 100) / 10;
                int Meot = num / 100;
                Console.WriteLine("the sum of the digits in the number is : {0}", Ahadot + Asarot + Meot);
                Console.WriteLine("{0}+{1}+{2}={3}", Meot * 100, Asarot * 10, Ahadot, num);
                Console.WriteLine("the opposite number is : {0}", Ahadot * 100 + Asarot * 10 + Meot);
            }
            else
            {
                Console.WriteLine("this number is not 3 digits number !!!!!!!!!!!!!");
            }

        }
    }
}
