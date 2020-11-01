using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            Console.WriteLine("enter a number between 10-20");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 30; i++)
            {
                int RA = R.Next(10, 21);
                if (Math.Abs(num - RA) <= 4)
                {
                    Console.WriteLine("{0} ", RA);
                }
            }
        }
    }
}
