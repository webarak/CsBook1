using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace הערך_הגדול_מבין_השניים
{
    class Program
    {
        public static int max(int num1, int num2)
       // טענת כניסה : קבלת שני מספרים
            // טענת יציאה : המספר הגדול מבין שני המספרים
        {
            int big = Math.Max(num1, num2);
            return big;
        }
        public static void biggest(int num1, int num2, int num3, int num4)
        // טענת כניסה : קבלת ארבעה מספרים
            // טענת יציאה : המספר הגדול מבין ארבעת המספרים
        {
            int big = max(max(num1, num2), max(num3, num4));
            Console.WriteLine("the biggest number is {0}", big);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter 4 numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            biggest(num1, num2, num3, num4);

        }
    }
}
