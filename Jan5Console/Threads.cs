using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jan5Console
{
    internal class Threads
    {
        static void F1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 1 o/p : " + i);
             Thread.Sleep(1000);
            }
        }
        static void F2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 2 o/p : " + i);
                Thread.Sleep(1000);
            }
            
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(F1);
            t1.Priority=ThreadPriority.Lowest;
            t1.Start();

            Thread t2 = new Thread(F2);
            t2.Priority = ThreadPriority.Highest;
            t2.Start();

            //Console.WriteLine("Is Alive : {0}", t1.IsAlive);
            //Console.WriteLine("Thread State : {0}", t1.ThreadState);
            //Console.WriteLine("Thread Name : {0}", t1.Name);
            //Console.WriteLine("Thread id : {0}", t1.ManagedThreadId);
            //Console.WriteLine("Thread Priority : {0}", t1.Priority);
            //Console.WriteLine("Runing in Background : {0}", t1.IsBackground);

            //Thread prop = Thread.CurrentThread;
            //prop.Name = "Test";
            //Console.WriteLine("Is Alive : {0}", prop.IsAlive);
            //Console.WriteLine("Thread State : {0}", prop.ThreadState);
            //Console.WriteLine("Thread Name : {0}", prop.Name);
            //Console.WriteLine("Thread id : {0}", prop.ManagedThreadId);
            //Console.WriteLine("Thread Priority : {0}", prop.Priority);
            //Console.WriteLine("Runing in Background : {0}", prop.IsBackground);
       
            Console.ReadLine();
        }
    }
}
