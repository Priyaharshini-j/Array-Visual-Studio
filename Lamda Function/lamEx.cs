using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FileFunc
{
    delegate int delex(int x, int y);
    internal class lamEx
    {
        static void Main34(string[] args)
        {

            var result = (int num1, int num2) => { 
            int total = 0;
            total = num1 + num2;
            return total;
             };
            Console.WriteLine(result(56, 7));
         }
  
    }
}
