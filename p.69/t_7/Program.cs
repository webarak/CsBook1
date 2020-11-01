using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many chocolate bars did you buy?");
            int buy = int.Parse(Console.ReadLine());
            Console.WriteLine("How many chocolate bars did you sell?");
            int sell = int.Parse(Console.ReadLine());
            if (buy*5 > sell*10)
            {
                Console.WriteLine("you are losing money!!! you need to sell more chocolate bars!!!");
            }
            else if(buy*5 < sell*10)
            {
                Console.WriteLine("you are getting money !!! keep up like this !!!");
            }
           
        }
    }
}
