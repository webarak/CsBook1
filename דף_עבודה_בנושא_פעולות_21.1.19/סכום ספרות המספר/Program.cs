using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace סכום_ספרות_המספר
{
    class Program
    {
        public static int sum(int num)
        // טענת כניסה : קבלת מספר
            // טענת יציאה : סכום ספרות המספר
        {
            int sum = 0;
            while (num != 0)
            {
                sum = sum + (num % 10) ;
                num = num / 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int sumd = sum(12312);
            Console.WriteLine(sumd);
        }
    }
}
