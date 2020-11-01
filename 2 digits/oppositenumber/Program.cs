using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oppositenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a 2 digits number");
            int num = int.Parse(Console.ReadLine());
            int oppositenumber = ((num%10)*10) + (num/10);
            Console.WriteLine("the opposite number is : {0}", oppositenumber);
        }
    }
}
