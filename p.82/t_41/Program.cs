using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of the points that Niv got");
            int Niv = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of the points that Dana got");
            int Dana = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of the points that Naama got");
            int Naama = int.Parse(Console.ReadLine());
            if ((Niv > Naama) && (Naama > Dana))
            {
                Console.WriteLine("Niv in the first place!");
                Console.WriteLine("Naama in the second place!");
                Console.WriteLine("Dana in the third place! ");
            }
            else if ((Niv > Dana) && (Naama<Dana))
            {
                Console.WriteLine("Niv in the first place!");
                Console.WriteLine("Dana in the second place!");
                Console.WriteLine("Naama in the third place! ");
            }
            else if ((Naama> Niv) && (Niv > Dana))
            {
                Console.WriteLine("Naama in the first place!");
                Console.WriteLine("Niv in the second place!");
                Console.WriteLine("Dana in the third place! ");
            }
            else if ((Naama > Dana) && (Niv < Dana))
            {
                Console.WriteLine("Naama in the first place!");
                Console.WriteLine("Dana in the second place!");
                Console.WriteLine("Niv in the third place! ");
            }
            else if ((Dana > Naama) && (Niv < Naama))
            {
                Console.WriteLine("Dana in the first place!");
                Console.WriteLine("Naama in the second place!");
                Console.WriteLine("Niv in the third place! ");
            }
            else if ((Dana > Niv) && (Niv > Naama))
            {
                Console.WriteLine("Dana in the first place!");
                Console.WriteLine("Niv in the second place!");
                Console.WriteLine("Naama in the third place! ");
            }
        }
    }
}
