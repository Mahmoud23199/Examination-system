using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class ClassB
    {
        public void Test(ITest i)
        {
            i.Fun1();
            Console.WriteLine(i.Fun2());
            Console.WriteLine(i.Fun3(5));
            Console.WriteLine(i.fun4());
        }
    }
}
