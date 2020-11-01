using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_53
{
    class Program
    {
        static void Main(string[] args)
        {
            double time = double.MaxValue;
            double time2 = 0;
            Console.WriteLine("how many cars?");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("what the time that took to the car?");
                double time1 = double.Parse(Console.ReadLine());
                if (time1 < time)
                {
                    time2 = time;
                    time = time1;
                }
                else if (time1 > time)
                {
                    if (time1 < time2)
                    {
                        time2 = time1;
                    }
                }
            }
            Console.WriteLine("the first place time is {0} and the second place time is {1}" ,time, time2);
        
        }
    }
}
