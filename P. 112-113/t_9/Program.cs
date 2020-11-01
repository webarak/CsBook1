using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_9
{
    class Program
    {
        static void Main(string[] args)
        {
             for (int i = 'a'; i <= 'z'; i=i+2)
            {
                Console.Write(" {0}", (char)i);
            }
        }
    }
}
