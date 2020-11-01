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
            Console.WriteLine("please enter the sum of the money");
            double sum = double.Parse(Console.ReadLine());
            double low = Math.Floor(sum);
            double ago = (sum - low)*100;
            Console.WriteLine("the sum of tha money is {0} shekels and {1} agorot", low, Math.Round(ago));
        }
    }
}
