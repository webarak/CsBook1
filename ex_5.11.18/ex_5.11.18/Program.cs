using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_5._11._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            int n1 = R.Next(-9, 10);
            Console.WriteLine("the first number is {0}", n1);
            int n2 = R.Next(-9, 10);
            Console.WriteLine("the second number is {0}", n2);
            int n3 = R.Next(-9, 10);
            Console.WriteLine("the third number is {0}", n3);
            double average = (double)(n1 + n2 + n3) / 3;
            Console.WriteLine("the average of this numbers is {0}", average);
        }
    }
}
