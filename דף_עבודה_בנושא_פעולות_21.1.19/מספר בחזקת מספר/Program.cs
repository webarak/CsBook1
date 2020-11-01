using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace מספר_בחזקת_מספר
{
    class Program
    {
        public static void hezka(int num1, int num2)
        // טענת כניסה : קבלת שני מספרים
            // טענת יציאה : המספר בחזקת השני ולהפך
        {
            int multiply1 = num1;
            int multiply2 = num2;
            for (int i = 1; i < num2; i++)
            {
                multiply1 = multiply1 * num1;
            }
            for (int i = 1; i < num1; i++)
            {
                multiply2 = multiply2 * num2;
            }
            Console.WriteLine("{0}, {1}", multiply1, multiply2);
        }
        static void Main(string[] args)
        {
            hezka(3, 2);
            
        }
    }
}
