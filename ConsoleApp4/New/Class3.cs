using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{
    //Consuming members of a class from non-child class of different projrct
    class Class3
    {
        static void Main()
        {
            ConsoleApp4.Program t = new ConsoleApp4.Program();
            t.Test5();
            Console.ReadLine();

        }
    }
}
