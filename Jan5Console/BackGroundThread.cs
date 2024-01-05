using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jan5Console
{
    internal class BackGroundThread
    {
        static void F1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Child BackGround " + i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {//Main Method is parent thread
            Console.WriteLine("Parent Thread Started");
            Thread td = new Thread(F1);
            td.IsBackground = true;
            Console.WriteLine("Is Child Background : {0} ", td.IsBackground);
            td.Start();
            Console.WriteLine("Parent Thread Stoped");
          
            Console.ReadLine();
        }
    }
}
