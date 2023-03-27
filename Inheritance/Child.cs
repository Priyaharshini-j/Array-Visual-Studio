using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overlod
{
    internal class Parent
    {
        public void Display()
        {
            Console.WriteLine("This is inside the Parent class");
        }
    }
    internal class Child :Parent { 
    public static void Main(string[] args)
        {
            var parent = new Parent();
            parent.Display();
            var seal = new shield();
            seal.shieldmethod();
        }
    }

    sealed class shield
    {
        public void shieldmethod()
        {
            Console.WriteLine("This is inside the sealed class");
        }
    }
}
