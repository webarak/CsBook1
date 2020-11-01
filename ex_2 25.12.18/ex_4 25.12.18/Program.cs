using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3_25._12._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int a = 1; a <= num; a++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }
        }
    }
}
