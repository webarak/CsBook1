using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace מחשבון
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please enter a number");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter a number");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("{0}+{1}={2}", num1, num2, num1 + num2);
            //Console.WriteLine("{0}-{1}={2}", num1, num2, num1 - num2);
            //Console.WriteLine("{0}*{1}={2}", num1, num2, num1 * num2);
            //Console.WriteLine("{0}:{1}={2}", num1, num2, (double) num1 / num2);



            Console.WriteLine("please enter a number");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("please choose athe mathematical act");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("please enter a number");
            float num2 = float.Parse(Console.ReadLine());
            if (ch == '+') 
            {
                Console.WriteLine("{0}+{1}={2}", num1, num2, num1 + num2);
            }
            else if (ch == '-')
            {
                Console.WriteLine("{0}-{1}={2}", num1, num2, num1 - num2);
            }
            else if (ch == '*')
            {
                Console.WriteLine("{0}*{1}={2}", num1, num2, num1 * num2);
            }
            else if (ch == '/')
            {
                Console.WriteLine("{0}/{1}={2}", num1, num2, (double)num1 / num2);
            }
            else if (ch == '^')
            {
                Console.WriteLine("{0}^{1}={2}", num1, num2, Math.Pow(num1, num2));
            }





            //Console.WriteLine("{0}+{1}={2}", num1, num2, num1 + num2);
            //Console.WriteLine("{0}-{1}={2}", num1, num2, num1 - num2);
            //Console.WriteLine("{0}*{1}={2}", num1, num2, num1 * num2);
            //Console.WriteLine("{0}:{1}={2}", num1, num2, (double) num1 / num2);
        }
    }
}
