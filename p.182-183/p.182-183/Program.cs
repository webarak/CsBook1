using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._182_183
{
    class Program
    {
        public static void reg(int rohav, int orech)
        // ט.כניסה : גדלי צלעות של מלבן
            // ט.יציאה : השטח, ההיקף של המלבן
        {
            Console.WriteLine("the S of the rectengale is {0}", rohav * orech);
            Console.WriteLine("the P of the rectengale is {0}", (rohav + orech) * 2);
            Console.WriteLine();
        }
        public static void draw(int rohav, int orech)
            // ט.כניסה : אורך ורוחב של מלבן
            // ט.יציאה : ציור של המלבן
        {
            for (int i = 1; i <= rohav; i++)
            {
                for (int J = 1; J <= orech; J++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void bigger(int rohav, int orech)
        //ט.כניסה : אורך ורוחב של מלבן
            // ט.יציאה : שטח והיקף של מלבן שגדול באורכו פי 2 וברוחבו ב-3
        {
            reg(rohav*2, orech - 3);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter the width of the rectengale");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the lenth of the rectengale");
            int lenth = int.Parse(Console.ReadLine());
            reg(width, lenth);
            draw(width, lenth);
            bigger(width, lenth);
        }
    }
}
