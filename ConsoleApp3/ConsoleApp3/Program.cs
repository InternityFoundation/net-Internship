using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        int i; bool b;
        static void Main(string[] args)
        {
            Program p = new ConsoleApp3.Program();
            Console.WriteLine("value of i is:" + p.i);
            Console.WriteLine("value of b is:" + p.b);
            Console.ReadLine();
        }
    }
}
