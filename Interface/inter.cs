using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overlod
{
    public interface inter
    {
        public void add(int a, int b);
        public void show();
        public void display(string name)
        {
            Console.WriteLine(name);        
        }
    }
    internal class child: inter
    {
        public void add( int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void show()
        {
            Console.WriteLine("This is inside of Child class");
        }
        
        public static void Main(string[] args)
        {
            child l = new child();
            inter p = new child();
            l.add(8,4);
            l.show();
            p.display("thi is Me");

        }
    }
}
