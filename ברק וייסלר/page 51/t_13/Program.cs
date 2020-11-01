using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the dollar rate");
            double dollarrate = double.Parse(Console.ReadLine());
            Console.WriteLine("please enter the cost of the trip in dollars");
            double costtrip = double.Parse(Console.ReadLine());
            Console.WriteLine("the cost of the trip in shekels is : {0}", (double)costtrip * dollarrate + 400 * dollarrate);
        }
    }
}
