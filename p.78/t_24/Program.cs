using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a letter");
            char ch = char.Parse(Console.ReadLine());
            if (((ch <= 'z') && (ch >= 'a')) || ((ch <= 'Z')&&(ch >= 'A')))
            {
                Console.WriteLine("the letter is one of the letters between a-z and A-Z. The letter is {0}", ch);
            }
            else
            {
                Console.WriteLine("the letter isn't one of the letters between a-z and A-Z");
            }

        }
    }
}
