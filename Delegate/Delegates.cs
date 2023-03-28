using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFunc
{
   public delegate int del_sub(int a, int b);
    internal class Delegates
    {
        public static int subtraction(int a, int b)
        {
            return(a-b);
        }
    }
    internal class Class2

    {
        //initializing the function to the delegate
        public static void Main4(string[] args)
        {
            del_sub delet=Delegates.subtraction;
            Console.WriteLine(delet(1,2));
            Console.WriteLine(delet.DynamicInvoke(4, 1));
        }
             

    }
}

