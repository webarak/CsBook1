using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_7
{
    class Program
    {
        public static int odd(int num1)
            // טענת כניסה = קבלת מספר
            // טענת יציאה = מספר הספרות הזוגיות
        {
            int count = 0;
            while (num1 != 0)
            {
                int a = num1 % 10;
                if (a % 2 == 0)
                {
                    count = count + 1;
                }
                num1 = num1 / 10;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of times");
            int n = int.Parse(Console.ReadLine());
            int numz = 0;
            int numb = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("enter a number");
                int number = int.Parse(Console.ReadLine());
                int z = odd(number);
                if (z > numz)
                {
                    numz = z;
                    numb = number;
                }
            }
            Console.WriteLine();
            Console.WriteLine(numb);
        }
    }
}
