using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //Consuming members of a class from non-child class of same projrct
    class Class2
    {
        static void Main()
        {
            Program p = new Program();
            p.Test2();
            p.Test4();
            p.Test5();
            Console.ReadLine();
        }

    }
}
