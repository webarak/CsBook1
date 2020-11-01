
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number with 2 digits");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The number of the Asarot is {0}, and the number of the Ahadot is {1}", num / 10, num % 10);
        }
    }
}
