using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p174_6
{
    class Program
    {
        //public static int randNum(int n1, int n2)
        ////טץכניסה:2 מספרים שלמים
        ////ט.יציאה: מספר אקראי בין המספרים
        //{
        //    int a = Math.Min(n1, n2);
        //    int b = Math.Max(n1, n2);
        //     Random r = new Random();
        //    return r.Next(a, b);
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("enter 2 numbers");
        //    int num1 = int.Parse(Console.ReadLine());
        //    int num2 = int.Parse(Console.ReadLine());
        //    while (num1 != -999 || num2 != -999)
        //    {
        //        for (int i = 1; i <= 5; i++)
        //        {
        //            Console.WriteLine(randNum(num1, num2));
        //        }
        //        Console.WriteLine("enter 2 numbers");
        //        num1 = int.Parse(Console.ReadLine());
        //        num2 = int.Parse(Console.ReadLine());
        //    }
        //}




        // תיקון מספר אקראי
        //-------------------------------------
        public static int randNum(int n1, int n2, Random r)
        //טץכניסה:2 מספרים שלמים
        //ט.יציאה: מספר אקראי בין המספרים
        {
            int a = Math.Min(n1, n2);
            int b = Math.Max(n1, n2);
            // Random r = new Random();
            return r.Next(a, b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Random r = new Random();
            while (num1 != -999 || num2 != -999)
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(randNum(num1, num2, r));
                }
                Console.WriteLine("enter 2 numbers");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
            }
        }
    }
}
