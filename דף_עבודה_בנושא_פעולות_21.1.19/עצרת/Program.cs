using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace עצרת
{
    class Program
    {
        public static int atheret(int num)
        // טענת כניסה : מספר
            // טענת יציאה : העצרת של המספר
        {
            int multiplay = 1;
            for (int i = 1; i <= num; i++)
            {
                multiplay = multiplay * i;
            }
            return multiplay;
        }
        static void Main(string[] args)
        {
            int a = atheret(5);
            Console.WriteLine("the atheret of the number is {0}", a);
        }
    }
}
