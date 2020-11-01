using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace האם_ספרה_נמצאת_במספר
{
    class Program
    {
        public static bool app(int num, int digit)
        // טענת כניסה : מקבלת ספרה וספרה
            // טענת יציאה : האם הספרה מופיעה במספר (true/false)
        {
            bool yes = false;
            while (yes == false && num != 0)
            {
                if ((num % 10) == digit)
                {
                    yes = true;
                }
                num = num / 10;
            }
            return yes;
        }
        public static void newnumber(int num1, int num2)
        // טענת כניסה : קבלת שני מספרים
            // טענת יציאה : מספר הבנוי מכל הספרות המשותפות לשני המספרים
        {
            int newnumber = 0;
            int num4 = num1;
            int num3 = num2;
            bool yes = false;
            
            while (num4 != 0 && yes != true)
            {

                num1 = num3;
                int a = num4%10;
                bool no = app(num1, a);
                if (no == true)
                {
                    
                    newnumber = (newnumber * 10) + a;
                }
                num4 = num4 / 10;
               
            }
            Console.WriteLine(newnumber);
            
            
           
           
        }
        
        static void Main(string[] args)
        {
            newnumber(123, 122);
    
        }
    }
}
