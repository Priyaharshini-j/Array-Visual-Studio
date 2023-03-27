using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overlod
{
    internal class Aggre
    {
        static void Main(string[] args)
        {
            Marks m = new Marks(320, 4);
            Student s = new Student("Priya", 22, 13, m);
            s.display();
        }
    }
    public class Student
    {
        string name;
        int age;
        int id;
        Marks m;
        public Student(string name,
        int age,
        int id,
        Marks m)
        {
            this.m = m;
            this.name = name;
            this.id = id;
            this.age = age;
        }
        public void display()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(id);
            m.Percent();
        }
    }
    public class Marks
    {
        int total_marks;
        float percent;
        int no_of_sub;

        public Marks(int total_marks, int no)
        {
            this.total_marks = total_marks;
            this.no_of_sub = no;
        }
        public void Percent()
        {
            percent = total_marks/ no_of_sub;
            Console.WriteLine("This is the percent:"+percent);
        }
    }
}
