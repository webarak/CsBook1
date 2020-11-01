using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_40
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumroei = 0;
            int sumtal = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("enter tal points in the game");
                int talp = int.Parse(Console.ReadLine());
                Console.WriteLine("enter roei points in the game");
                int roeit = int.Parse(Console.ReadLine());
                if (roeit>talp)
                {
                    sumroei = sumroei+roeit;
                    sumtal = sumtal + talp;
                    Console.WriteLine("roei won the game");
                }
                else if (talp>roeit)
                {
                    sumtal = sumtal+talp;
                    sumroei = sumroei + roeit;
                    Console.WriteLine("tal won the game");
                }
            }
            if (sumtal>sumroei)
            {
                Console.WriteLine("tal got the most of the points in the games");
            }
            else if (sumroei>sumtal)
            {
                Console.WriteLine("roei got the most of points in the games");
            } 
        }
    }
}
