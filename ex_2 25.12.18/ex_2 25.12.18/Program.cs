using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_25._12._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many rows?");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("how many coloms?");
            int num1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int a = 1; a <= num1; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}
