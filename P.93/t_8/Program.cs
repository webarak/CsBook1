using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a day in a month");
            int Day = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter a month in a year");
            int Month = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter a year");
            int Year = int.Parse(Console.ReadLine());
            switch (Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if ((Day < 1) || (Day > 31))
                      
                        Console.WriteLine("the date is invaild");
                
                    else
                    
                        Console.WriteLine("the date is vaild");
                
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if ((Day < 1) || (Day > 30))

                        Console.WriteLine("the date is invaild");

                    else

                        Console.WriteLine("the date in vaild");
                    break;
                case 2:
                    if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                    {
                        if ((Day < 1) || (Day > 29))

                            Console.WriteLine("the date is invaild");

                        else

                            Console.WriteLine("the date is vaild");

                    }
                    else
                    {
                        if ((Day < 1) || (Day > 28))

                            Console.WriteLine("the date is invaild");

                        else

                            Console.WriteLine("the date is vaild");

                    }
                    break;
                default: Console.WriteLine("the date is invaild"); break;

            }
        }
    }
}
