using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFunc
{
    internal class LamdaExp
    {
      // delegate int add(int a, int b);

        delegate void Greet(string msg);
        static void Main76(string[] args)
        {


           //sum2(num1,num2)=> num1 + num2;
            Greet M = (str)=>Console.WriteLine(str);
            var sum =(int num1, int num2) => num1 + num2;
            var sub = (int num1, int num2)=> num1 - num2;
            var mul = (int num1, int num2) => num1 * num2;


            Console.WriteLine(mul(2, 30));
            mul += sum;
            var div = (int num1, int num2) => num1 / num2;
            Console.WriteLine(div(30,2));
            div  -= sub;
            foreach(Delegate a in div.GetInvocationList())
            {
                Console.WriteLine(a.DynamicInvoke(35,5));
            }
            foreach(Delegate a in mul.GetInvocationList())
            {
                Console.WriteLine(a.DynamicInvoke(2, 3));
            }
            Console.WriteLine(sum(20, 30));
            Console.WriteLine(sub(34,24));
            M.Invoke("Hi");
        }


    }
}
