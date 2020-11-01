using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the former high of the bounce of the ping pong ball");
            double former = double.Parse(Console.ReadLine());
            Console.WriteLine("please enter the latter high of the bounce of the ping pong ball");
            double latter = double.Parse(Console.ReadLine());
            if (former < latter)
            {
                Console.WriteLine("the ball is taking of");
            }
            else
            {
                Console.WriteLine("the ball is retreating");
            }
        }
    }
}
