using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the middle grade");
            double grade = double.Parse(Console.ReadLine());
            double grade1 = Math.Round(grade);
            double moregrade = (Math.Round((grade - grade1)*100))/100;
            Console.WriteLine("the round grade is {0} and the part that saved to the final frade in the end of the year is {1}", grade1, moregrade);
        }
    }
}
