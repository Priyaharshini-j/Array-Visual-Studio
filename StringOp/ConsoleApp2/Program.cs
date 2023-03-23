namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello World!";
            string name = "User";
            Console.WriteLine(greeting.Replace('o','a'));
            Console.WriteLine(greeting.IndexOf('!'));
            Console.WriteLine(String.Concat(greeting,name));
            Console.WriteLine(String.Equals(name,greeting));
            Console.WriteLine(greeting.Substring(0,6));
            string outcome = String.Concat(greeting, name);
            Console.WriteLine(outcome);

            // Compare
            Console.WriteLine("Comaring outcome and Name");
            Console.WriteLine(String.Compare(name, outcome,StringComparison.Ordinal));

            // Equals
            Console.WriteLine(String.Equals("Abc","abc",StringComparison.OrdinalIgnoreCase));

            // double quotes

            String example = "This is \" Pancake \" Tuesday ";
            Console.WriteLine(example);

            //dynamic initialization
            String user_name=Console.ReadLine();
            String exp = $"This is \" Pancake \" Tuesday {user_name} Welcome!";
            Console.WriteLine(exp);

            //Spliiting the string
            String[] spl = exp.Split(" ");

            Console.WriteLine(spl[1]);

            // format, join, length, toCharArray, Aggregate
        }
    }
}