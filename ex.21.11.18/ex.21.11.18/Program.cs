using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex._21._11._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                int R1 = R.Next(-9, 10);
                if (R1 < 0)
                    sum = sum + 1;
            }
            Console.WriteLine(sum);
        }
    }
}
