using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_41
{
    class Program
    {
        static void Main(string[] args)
        {
            int candle = 2;;
            int sum = 0;
            for (int i = 1; i <= 8; i++)
            {
                sum = sum + candle;
                candle = candle + 1;
            }
            Console.WriteLine(sum);
        }
    }
}
