using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFunc
{
    delegate int mathOperation(int a, int b);

    internal class VariousDelegates
    {
        int add(int a, int b) { return (a + b); }
        int sub(int a, int b) { return a - b; }
        int mul(int a, int b) { return a * b; }
        int div(int a, int b) { return a / b; }
        int mod(int a, int b) { return a % b; }

        static void main(string[] args)
        {
            {
                VariousDelegates func = new VariousDelegates();
                mathOperation maOp1 = func.add;
                mathOperation maOp2 = func.sub;
                mathOperation maOp3 = func.mul;
                mathOperation maOp4 = func.div;
                mathOperation maOp5 = func.mod;

                Console.WriteLine("Addition: " + maOp1.Invoke(3, 5));
                Console.WriteLine("Subtraction: " + maOp2.Invoke(3, 5));
                Console.WriteLine(maOp3.Invoke(3, 5));
                Console.WriteLine(maOp4.Invoke(3, 5));
                Console.WriteLine(maOp5.Invoke(3, 5));

            }
        }

    }
}
