using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal interface ITest
    {

        void Fun1();
        int Fun2();
        int Fun3(int x);

       int fun4() {  return 0; }

    }

    class ClassA : ITest
    {
        public void Fun1()
        {
            Console.WriteLine("ClassA Fun1");
        }

        public int Fun2()
        {
            Console.WriteLine("ClassA Fun2");
            return 10;

        }

        public int Fun3(int x)
        {
            Console.WriteLine("ClassA Fun3");
            return x;

        }
    }


    class ClassC:ITest
    {
        public void Fun1()
        {
            Console.WriteLine("Hello From Fun1 ClasssC");
        }

        public int Fun2()
        {
            Console.WriteLine("Hello From Fun2 ClasssC");
            return 7;

        }

        public int Fun3(int x)
        {
            Console.WriteLine("Hello From Fun3 ClasssC");
            return x * 4;

        }
    }

    struct structD : ITest
    {
        public void Fun1()
        {
            Console.WriteLine("StructD Fun1");
        }

        public int Fun2()
        {
            Console.WriteLine("StructD Fun2");
            return -1;
        }

        public int Fun3(int x)
        {
            Console.WriteLine("StructD Fun3");
            return x * x;

        }
    }


}
