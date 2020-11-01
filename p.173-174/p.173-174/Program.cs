using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._173_174
{
    class Program
    {
        public static int numbernumbers(int number, int num)
            // טענת כניסה : מקבל מספר וספרה
            // טענת יציאה : סופר את כמות הפעמים שהספרה מופיעה במספר
        {
            int count = 0;
            while (number != 0)
            {
                
                if (number % 10 == num)
                {
                    count++;
                }
                number = number / 10;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a digit");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("the number {0} apperes in the number {1} times", num2, numbernumbers(num1, num2));
        }
    }
}
