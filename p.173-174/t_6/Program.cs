using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_6
{
    class Program
    {
        public static int dif(int num1, int num2)
        // טענת כניסה : קבלת שני מספרים שונים
        // טענת יציאה : מספר מוגרל בתחום שני המספרים
        {
            Random R = new Random();
            int a = Math.Min(num1, num2);
            int b = Math.Max(num2, num1);
            int Ran = R.Next(a, b);
            return Ran;
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("enter a number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter another number");
            int b = int.Parse(Console.ReadLine());
            while ((a != -999) || (b != -999))
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(dif(a, b));
                }
                Console.WriteLine("enter a number");
                 a = int.Parse(Console.ReadLine());
                Console.WriteLine("enter another number");
                 b = int.Parse(Console.ReadLine());
            }
        }
    }
}
