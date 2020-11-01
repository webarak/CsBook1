using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._184_185
{
    class Program
    {
        public static int grades(int grade, int yahal)
        // טענת כניסה : ציון ומספר יחידות
            // טענת יציאה : ציון משוכלל במקצוע מסוים
        {
           
            if (yahal == 5)
            {
                grade = grade + 20;
            }
            if (yahal == 4)
            {
                grade = grade + 10;
            }
            return grade;
        }
        static void Main(string[] args)
        {
            double avarage = 0;
            Console.WriteLine("enter the numbers of the tests");
            int tests = int.Parse(Console.ReadLine());
            for (int i = 1; i <= tests; i++)
            {
                Console.WriteLine("enter your grade");
                int grade = int.Parse(Console.ReadLine());
                Console.WriteLine("enter your units");
                int yahal = int.Parse(Console.ReadLine());
                int grading = grades(grade, yahal);
                avarage = avarage + grading;
            }
            Console.WriteLine("the avarage of your bagrut teoda is : {0}", avarage / tests);
        }
    }
}
