namespace Generic
{

    class Class1<T>
    {
        public Class1(T Message)
        {
            Console.WriteLine(Message);
        }
    }
    public class Test
    {
        public static void Main(string[] args)
        {
            Class1<string> c = new Class1<string>("Hola");

            // For multiple message 
            Class1<int> e= new Class1<int>(1234);
            Class1<float> d= new Class1<float>(3683.484f);

            //List

            List<int> list= new List<int>();
            // Add function
            list.Add(1);
            list.Add(2);
            list.Add(3);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(list.BinarySearch(2));

            var l1 = new List<string> { "Apple", "Ball", "Cat","Bat" };

            l1.Remove("Ball");

            foreach(var f in l1)
            {
                Console.WriteLine(f); 
            }

            //Hashset
           var s = new HashSet<string>() { "Add", "Sub", "Sub" };

            // other method of initializing will be
            var hashset1 = new HashSet<string>() { "two", "three","two", "one" };
           

            foreach(var i in hashset1 ) { 
                Console.WriteLine(i);
            }


            //SortedSet
            var ss = new SortedSet<float>() { 23.3f, 23.4f, 465.1f, 1.8f, 8.9f };
            foreach(var i in ss )
            {
                Console.WriteLine(i);
            }


            //Stack

            var stack = new Stack<int>();
            stack.Push(75);
            stack.Push(1);
            stack.Push(73);
    
            while (stack.Count != 0)
            {
                Console.WriteLine("The Top most Element is: " + stack.Pop());
                if(stack.Count != 0)
                Console.WriteLine("The Next Element is "+stack.Peek());

            }

            //Queue

        var qu=new Queue<int>();
            qu.Enqueue(6);
            qu.Enqueue(7);
            qu.Enqueue(qu.Count);
            qu.Enqueue(9);

            Console.WriteLine(qu.Dequeue());
            Console.WriteLine(qu.Count());


        }
    }
}

