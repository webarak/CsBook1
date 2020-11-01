using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the number of the students in first nine grade");
            int nine1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the number of the students in second nine grade");
            int nine2 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the number of the students in third nine grade");
            int nine3 = int.Parse(Console.ReadLine());
            int ninegrades = nine1 + nine2 + nine3;
            int buses = ninegrades / 40;
            if (ninegrades % 40 == 0)
            {
                Console.WriteLine("the school need to order {0} buses", buses);
            }
            else if (ninegrades % 40 != 0)
            {
                Console.WriteLine("the school need to order {0} buses", buses+1);
            }
        }
    }
}
