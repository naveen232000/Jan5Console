using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan5Console
{
    public class AsyncAwait
    {
        public static async Task F1()
        {
            await Task.Run(() => { 
            for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Async Function : {0}", i);
                    Task.Delay(1000).Wait();
                }
            });
        }
        public static void F2()
        {
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("Normal Function : {0}",i);
                Task.Delay(1000).Wait();    
            }
        }
        static void Main(string[] args)
        {
            F1();
            F2();
            Console.ReadLine();
        }
    }
}
