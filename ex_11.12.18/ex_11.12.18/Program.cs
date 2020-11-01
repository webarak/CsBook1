using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_11._12._18
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num = int.Parse(Console.ReadLine());
            while (num >= 0)
            {
                sum = sum + num;
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
