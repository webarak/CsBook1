using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_21
{
    class Program
    {
        public static int count(int num1)
        // טענת כניסה : קבלת מספר
        // טענת יציאה : סכום ספרות המספר
        {
            int sum = 0;
            while (num1 != 0)
            {
                sum = sum + (num1 % 10);
                num1 = num1 / 10;
            }
            return sum;
        }
        public static void min(int num)
        // טענת כניסה : קבלת מספר
        // טענת יציאה : הדפסת המספרים הקטנים מהמספר שסכום ספרותיהם שווה לסכום ספרותיו של המספר
        {

            int sumnum = count(num);
            for (int i = 1; i < num; i++)
            {
                int sum = count(i);
                if (sum == sumnum)
                {
                    Console.Write("{0} ", i);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a = int.Parse(Console.ReadLine());
            min(a);
        }
    }
}
