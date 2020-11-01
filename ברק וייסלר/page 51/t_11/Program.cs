using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the high of the triangle");
            int high = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the length of the rib of the triangle");
            int lengthbase = int.Parse(Console.ReadLine());
            Console.WriteLine("the area of the triangle is : {0} and the circumference of the triangle is {1}", (double)(high * lengthbase)/2 , lengthbase * 3);
        }
    }
}
