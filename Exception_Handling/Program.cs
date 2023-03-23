using System.Data;

namespace Exception_Handling
{
    internal class Program
    {
        public static void Main(string[] args)
        {
          /*  int a = 34;
            int b = 0;
            try
            {
                int c = a / b;
            }

            // Specific Exception catch
            catch (DivideByZeroException pe)
            {
                Console.WriteLine(pe.Message);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try {

                int[] arr = { 1, 2, 3 };

                for (int i = 0; i < 5; i++) {
                    Console.WriteLine(arr[i]);
                }
            }

            catch (IndexOutOfRangeException ind)
            {
                Console.WriteLine(ind.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("There is an error in calculation. " + "The error is " + e.Message);
            }
          */
            // User defined Exception

            int age = 12;
            try {
                AgeLimit(age);
            }

            // For Printing the general Exception
            catch (Exception ex)
            {
                Console.WriteLine("There is an error in calculation. " + "The error is " + ex.Message);
            }


            finally {
                Console.WriteLine("Its the finally block");

            }




            // NAmespace
            System.Data.DataTable dt= new DataTable();


        }


        // Checking the age limit
        public static void AgeLimit(int age)
        {
            if (age > 18)
            {
                throw new MyException("You Should be over 18");
            }
        }
            public class MyException: Exception
        {
            public MyException(string myMessage) : base(myMessage){ }


            }

        }
    }

