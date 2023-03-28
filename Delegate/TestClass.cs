using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFunc
{
    delegate void CustomDel(string s);
    class TestClass
    {
        // Define two methods that have the same signature as CustomDel.
        static void Hello(string s)
        {
            Console.WriteLine($"  Hello, {s}!");
        }

        static void Goodbye(string s)
        {
            Console.WriteLine($"  Goodbye, {s}!");
        }

        static void TestMain()
        {

            CustomDel hiDel, byeDel, multiDel, multiMinusHiDel;
            hiDel = Hello;
            byeDel = Goodbye;
            multiDel = hiDel + byeDel;
            multiMinusHiDel = multiDel - hiDel;

            Console.WriteLine("Invoking delegate hiDel:");
            hiDel("A");
            Console.WriteLine("Invoking delegate byeDel:");
            byeDel("B");
            Console.WriteLine("Invoking delegate multiDel:");
            multiDel("C");
            Console.WriteLine("Invoking delegate multiMinusHiDel:");
            multiMinusHiDel("D");
        }
    }
}

