using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace דף_עבודה_בנושא_פעולות_21._1._19
{
    class Program
    {
        public static int avg(int num1, int num2)
        // טענת כניסה : קבלת שני מספרים
            // טענת יציאה : הממוצע הממשי של המספרים
        {
            int avarage = (num1 + num2) /2;
            return avarage;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int av = avg(num1, num2);
            Console.WriteLine("the avarage is {0}", av);
        }
    }
}
