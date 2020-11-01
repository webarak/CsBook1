using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._131_32
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = 0;
            int y = 1;
            Console.WriteLine("enter the jumping high of the first student");
            double num = double.Parse(Console.ReadLine());
            max = num;
            for (int i = 2; i <= 8; i++)
            {
                Console.WriteLine("enter the jumping high of the next student");
                num = double.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                    y = i;
                }
                
            }
            Console.WriteLine("the {0} student jump highest his jumping high is {1}", y, max);
        }
    }
}
