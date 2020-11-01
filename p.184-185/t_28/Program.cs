                                                        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_28
{
    class Program
    {
        public static int number(int num)
        // טענת כניסה : קבלת מספר
            // טענת יציאה : אם המספר מורכב מספרות שונות בלבד או לא
        {
            int sum = 0;
            int num2 = num;
            int num3 = num;
            bool yes = false;
            while (num2 != 0 && yes != true)
            {
                num = num3;
                sum = 0;
                int a = digit(num2);
                while (num != 0)
                {
                    
                    if (num % 10 == a)
                    {
                        sum = sum + 1;
                    }
                    num = num / 10;
                    
                }
                if (sum > 1)
                {
                    sum = 0;
                    yes = true;
                }
                num2 = num2 / 10;
               
            }
            
            
           
            return sum;
        }
        public static int digit(int num)
        // טענת כניסה : קבלת מספר
            //  טענת יציאה :  ספרת היחידות של המספר
        {
            int a = num % 10;
            return a;
        }
        static void Main(string[] args)
        {
            int counter = 0;
            int shone = 0;
            while (shone != 1)
            {
                counter++;
                Console.WriteLine("enter number");
                int num = int.Parse(Console.ReadLine());
                shone = number(num);
                if (shone == 1)
                {
                    Console.WriteLine("the number {0} have only different digits. this number is the {1} number that you enterred.", num, counter);
                }

            }
        }
    }
}
