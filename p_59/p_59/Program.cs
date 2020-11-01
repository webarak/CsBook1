using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the current time in minutes");
            int minutes = int.Parse(Console.ReadLine());
            int hours = minutes / 60;
            int minute = minutes % 60;
            Console.WriteLine("the time is {0} hours and {1} minutes", hours, minute);
        }
    }
}
