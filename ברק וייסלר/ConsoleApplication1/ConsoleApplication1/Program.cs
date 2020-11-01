using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
 
    class Program
    {
        static void Main(string[] args)
        {

            Person father = new Person("rafi", 40);
            Person mother = new Person  ("limor",42);
            Person son = new Person("alon", 10);
            Person dugter = new Person("hila", 18);

           

            Console.WriteLine(father.getname());
            Console.WriteLine(father.getage());
            Console.ReadLine();

            double age = father.getage() + 1;
            father.setage(age);
            Console.WriteLine(father.getage());
        }
    }
}
