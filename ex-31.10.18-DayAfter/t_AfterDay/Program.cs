using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_AfterDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the number of the day");
            int Day = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the number of the month");
            int Month = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the number of the Year");
            int Year = int.Parse(Console.ReadLine());
            switch (Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    if ((Day >= 1) && (Day < 31))
                    
                        Console.WriteLine("the date of the next day is {0}/{1}/{2}", Day + 1, Month, Year);
                    
                    else if (Day == 31)
                    
                        Console.WriteLine("the date of the next day is {0}/{1}/{2}", 1, Month + 1, Year);
                    
                    break;
                case 12:
                    if ((Day >= 1) && (Day < 31))

                        Console.WriteLine("the date of the next day is {0}/{1}/{2}", Day + 1, Month, Year);
                    
                    else if (Day == 31)

                        Console.WriteLine("the date of the next day is {0}/{1}/{2}", 1, 1, Year + 1);
                    
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if ((Day >= 1) && (Day < 30))

                        Console.WriteLine("the date of the next day is {0}/{1}/{2}", Day + 1, Month, Year);
                    
                    else if (Day == 30)

                        Console.WriteLine("the date of the next day is {0}/{1}/{2}", 1, Month + 1, Year);
                    
                    break;
                case 2:
                    if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                    {
                        if ((Day >= 1) && (Day < 29))

                            Console.WriteLine("the date of the next day is {0}/{1}/{2}", Day + 1, Month, Year);
                        
                        else if (Day == 29)

                            Console.WriteLine("the date of the next day is {0}/{1}/{2}", 1, Month + 1, Year);
                        
                    }
                    else 
                    {
                        if ((Day >= 1) && (Day < 28))


                            Console.WriteLine("the date of the next day is {0}/{1}/{2}", Day + 1, Month, Year);
                        
                        else if (Day == 28)

                            Console.WriteLine("the date of the next day is {0}/{1}/{2}", 1, Month + 1, Year);
                        
                    }
                    break;
                default: Console.WriteLine("wrong date");
                    break;

              } 
          }
      }
}

