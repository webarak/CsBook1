using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number with 3 digits");
            int num = int.Parse(Console.ReadLine());
            if ((num / 100 > 0) && (num / 100 < 10))
            {
                int Meot = num / 100;
                int Asarot = (num % 100) / 10;
                int Ahadot = num % 10;
                Console.WriteLine("The number of the Meot is {0}, the number of the Asarot is {1}, and the number of the Ahadot is {2}", Meot, Asarot, Ahadot);
            }
            else if ((num / 100 < 0) || (num / 100 >= 10))
            {
                Console.WriteLine("EROR !!!  THIS NUMBER IS NOT 3 DIGITS NUMBER !!!");
            }

        }
    }
}
