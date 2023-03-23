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
        }
    }
}

