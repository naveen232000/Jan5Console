using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Jan5Console
{
    internal class AsyncReadFile
    {
        static async void CallFun()
        {
            string filePath = @"D:\Mphasis\SimpleliLearn Doc .net\5jan\AsyncReadTest.txt";
            Task<string> t1 = ReadFile(filePath);
            string txt = await t1;
            Console.WriteLine("\nContent in File :\n");
            Console.WriteLine(txt);


        }

        static async Task<string> ReadFile(string f)
        {
           string txt;
            Console.WriteLine("File Reading is startiing");
            using (StreamReader sr = new StreamReader(f))
            {
                string content = await sr.ReadToEndAsync();
                txt = content;
            }
            Console.WriteLine("\nFile reading completed ");
            return txt;
        }
        static void Main(string[] args)
        {
            Task t1 = new Task(CallFun);
            t1.Start();
            t1.Wait();
            Console.ReadLine();
        }

    }
}
