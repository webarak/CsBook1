using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_22
{
    class Program
    {
        public static void digits(int num, int digit)
        // טענת כניסה : מקבלת מספר וספרה
            // טענת יציאה : מיקומי הספרה במספר
        {
            int place = 1;
            int wrong = 0;
            while (num != 0)
            {
                
                if (num % 10 == digit)
                {
                    Console.Write("{0} ", place);
                    wrong++;
                }
                
                num = num / 10;
                place++;
            }
            if (wrong == 0)
            {
                Console.Write(wrong);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("the number {0} apeared in those places : ", i);
                digits(num, i);
                Console.WriteLine();
            }
        }
    }
}
