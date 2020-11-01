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
            int count = 0;
            for (int i = 1; i <= 300; i++)
            {
                if (Math.Sqrt(i) % 1 == 0)
                {
                    count = count + 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
