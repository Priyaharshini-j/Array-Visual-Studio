using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FileFunc
{
        class AnonymousFunction
        {

            public static void Main0()
            {

                List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8,9,12,15};
                List <int> Div = nums.FindAll(n=>{return n%3==0;});
                Console.WriteLine($"The Div Count is: {Div.Count}");
                var square = (int n) => { return n * n; };
                Console.WriteLine("The Square is: ");
                foreach (int num in nums)
                    {
                        Console.WriteLine(square(num));
                    }
                var Divisibleby5 = (int divisible) => { return divisible % 5==0; };
                foreach (int num in nums)
                {
                    Console.WriteLine(Divisibleby5(num));
                }

                }

                
        }
    }

