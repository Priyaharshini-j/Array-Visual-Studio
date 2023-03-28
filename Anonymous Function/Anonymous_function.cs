using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFunc
{
    internal class Anonymous_function
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
            static void AnonyMain(string[] args)
            {
                CustomDel cd = new CustomDel(delegate (string s) { Console.WriteLine(s); });
                CustomDel cd1, cd2;
                cd1 = Hello;
                cd2 = Goodbye;
                cd.Invoke("Welcome Guys!");
                cd1.Invoke("Priya");
                cd2.Invoke("Take Care");

            }
        }
    }
}
