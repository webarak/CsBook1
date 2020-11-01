using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the temp today");
            int num = int.Parse(Console.ReadLine());
            for (int day = 2; day <= 30; day++)
            {
               
                int y = num;
                Console.WriteLine("enter the next day temp");
                num = int.Parse(Console.ReadLine());
                if (num > y)
                {
                    Console.WriteLine(day);
                }
            }
        }
    }
}
