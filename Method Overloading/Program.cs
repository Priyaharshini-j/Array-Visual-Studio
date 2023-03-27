namespace Overlod
{
    internal class Program
    {
        enum days{
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,Sunday
        }
         static void Main(string[] args)
        {
            Overloading("This is PRiyadharshini");
            Overloading("Priyadharshini", 13);
            Overloading("Priyadharshini", 13, days.Sunday);

        }
        public static void Overloading(string name)
        {
            Console.WriteLine(name);
        }
        private static void Overloading(string name, int id)
        {
            Console.WriteLine(name+"  "+id);
        }
        private static void Overloading(string name, int id, days d)
        {
            Console.WriteLine(d);
        }
    }
}
