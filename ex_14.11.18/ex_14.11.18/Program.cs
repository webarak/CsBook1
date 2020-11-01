using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_14._11._18
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 999; i++)
            {
            
                
                int M = i / 100;
                int A = (i % 100) / 10;
                int Y = i % 10;
                if ((Math.Pow(M, 3)) + (Math.Pow(A, 3)) + (Math.Pow(Y, 3)) == i)
                {
                    Console.WriteLine(i);
                }
                
               
            
            }
        }
    }
}
