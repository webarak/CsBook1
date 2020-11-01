using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._120
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("Enter the temp");
                int temp = int.Parse(Console.ReadLine());
                if (temp > 16)
                {
                    count = count + 1;
                }
                
            }
            Console.WriteLine("the number of the days that the temp was over than 16 degris is : {0}", count);
        }
    }
}
