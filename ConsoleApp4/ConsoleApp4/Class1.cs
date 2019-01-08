using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //Consuming members of a class from child class of same project
    class Class1 : Program
    {
        static void Main()
        {
            Class1 t = new Class1();
            t.Test2();
            t.Test3();
            t.Test4();
            t.Test5();
            Console.ReadLine();
        }
    }
}
