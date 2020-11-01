using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a letter");
            char ch1 = char.Parse(Console.ReadLine());
            Console.WriteLine("please enter another letter");
            char ch2 = char.Parse(Console.ReadLine());
            Console.WriteLine("please enter another letter");
            char ch3 = char.Parse(Console.ReadLine());
            if (ch1 > ch2)
            {
                
                if (ch2 > ch3)
                {
                    Console.WriteLine("the letters are in down organize");
                }
                else
                {
                   Console.WriteLine("the letters aren't organise");
                }  
            
            }
            else
            {
                if (ch3 > ch2)
                {
                   
                    if (ch2 > ch1)
                    {
                        Console.WriteLine("the letters are in up organize");
                    }
                    else
                    {
                        Console.WriteLine("the letters aren't organise");
                    }
                    
                }
                else
                {
                    Console.WriteLine("the numbers aren't organise");
                }
            }
        }
    }
}
