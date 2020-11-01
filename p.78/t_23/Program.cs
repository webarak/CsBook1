using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your age");
            double age = double.Parse(Console.ReadLine());
            Console.WriteLine("please enter your expirience time in managing");
            double ex = double.Parse(Console.ReadLine());
            if ((age >= 35) && (age <= 45) && (ex >= 3))
            {
                Console.WriteLine("you are qualified to work in this job");
            }
            else
            {
                Console.WriteLine("you aren't qualified to work in this job");
            }
        }
    }
}
