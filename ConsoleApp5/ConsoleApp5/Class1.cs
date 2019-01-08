using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Class1:Mix
    {
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main()
        {
            Class1 c = new Class1();
            c.Test1();
            c.Test2();
            c.Test3();
            Console.ReadLine();
        }
    }
}
