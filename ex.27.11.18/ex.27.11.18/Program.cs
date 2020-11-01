using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex._27._11._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            int max = 0;
            int min = 1000;
            for (int i = 1; i <= 100; i++)
            {

                
                int num = R.Next(1001);
                Console.Write(num+" ");
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine("the biggest number is {0} and the lowest is {1}", max, min);
        }
    }
}
