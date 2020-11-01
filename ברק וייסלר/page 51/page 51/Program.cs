using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page_51
{
    class Program
    {
        static void Main(string[] args)
        {
            //9
            Console.WriteLine("please enter your year of birth");
            int yearofbirth = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the current year");
            int currentyear = int.Parse(Console.ReadLine());
            Console.WriteLine("your age is : {0}", currentyear - yearofbirth);

            //10

        }
    }
}
