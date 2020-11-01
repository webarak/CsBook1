using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_8
{
    class Program
    {
        public static int capisity(int p, int t)
            //טענת כניסה = קבלת מספר אנשים ותפוסה
            // טענת יציאה = מספר הדברים שצריך להזמין
        {
            int num = p / t;
            if (p % t != 0)
            {
                num = num + 1;
            }
            return num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of people");
            int people = int.Parse(Console.ReadLine());
            Console.WriteLine("enter cspisity of bus");
            int capbus = int.Parse(Console.ReadLine());
            Console.WriteLine("enter cspisity of table");
            int captable = int.Parse(Console.ReadLine());
            Console.WriteLine("enter cspisity of boat");
            int capboat = int.Parse(Console.ReadLine());
            int numbus = capisity(people, capbus);
            int numtable = capisity(people, captable);
            int numboat = capisity(people, capboat);
            Console.WriteLine("you need to order {0} busses, {1} tables and {2} boats", numbus, numtable, numboat);
        }
    }
}
