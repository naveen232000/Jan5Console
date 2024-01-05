using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan5Console
{
    internal class Program
    {//normal code 
        static void F1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 1 o/p : "+i);
            }
        }
        static void F2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 2 o/p : " + i);
            }
        }
        static void Main(string[] args)
        {
            F1();
            Console.WriteLine();
            F2();
            Console.ReadLine(); 
        }
    }
}
