using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jan5Console
{
    public class NonStat
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public void fun() {
            Console.WriteLine("Employe Id : {0} ",EmpId);
            Console.WriteLine("Employe Name : {0} ", Name);
        }
    }
    internal class ThreadClassProperty
    { //Thread to non static function
        static void Main(string[] args)
        {
            NonStat test = new NonStat() { EmpId=001,Name="Naveen"};
            Thread th=new Thread(test.fun); 
            th.Start();
            Console.ReadLine();
        }
    }
}
