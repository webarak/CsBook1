using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_26
{
    class Program
    {
        public static int time1(int hour, int minuts)
        // טענת כניסה : מקבלת שעות ודקות
            // טענת יציאה : הזמן בדקות
        {
            minuts = minuts + (hour * 60);
            return minuts; 
        }
        public static int time2(int hour, int minuts, int hour1, int minuts1)
        // טענת כניסה : מקבלת 2 זמנים בשעות ודקות
        // טענת יציאה : ההפרש בזמנים
        {
            minuts = time1(hour, minuts);
            minuts1 = time1(hour1, minuts1);
            int Hefresh = Math.Max(minuts1, minuts) - Math.Min(minuts1, minuts);
            return Hefresh;
        }
        static void Main(string[] args)
        {
            int i, d = 1;
            Console.WriteLine("enter the hour that you start to work, first hour and than minuts");
            int hour1 = int.Parse(Console.ReadLine());
            int minuts1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the hour that you finished to work, first hour and than minuts");
            int hour2 = int.Parse(Console.ReadLine());
            int minuts2 = int.Parse(Console.ReadLine());
            int timework1 = time2(hour1, minuts1, hour2, minuts2);
            int timework2 = 0;
            for ( i = 2; i <= 5; i++)
            {
                Console.WriteLine("enter the hour that you start to work, first hour and than minuts");
                 hour1 = int.Parse(Console.ReadLine());
                 minuts1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the hour that you finished to work, first hour and than minuts");
                 hour2 = int.Parse(Console.ReadLine());
                 minuts2 = int.Parse(Console.ReadLine());
                 timework2 = time2(hour1, minuts1, hour2, minuts2);
                 if (timework2 > timework1)
                 {
                     timework1 = timework2;
                     d = i;
                 }
            }
            Console.WriteLine("the worker work the most hours in day: {0}", d);


        }
    }
}
