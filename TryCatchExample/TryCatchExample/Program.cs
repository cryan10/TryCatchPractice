using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*           try
                       {
                           Console.WriteLine("Enter a number: ");
                           int number = int.Parse(Console.ReadLine());
                           Console.WriteLine("your number is {0}", number);
                       }

                       catch (FormatException objectiveName)
                       {
                           Console.WriteLine("That is not a valid number");
                       }

               */

            /*
            try
            {
                Console.WriteLine("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Your number is {0}", number);
            }

            finally
            {
                Console.WriteLine("thanks for playing");
            }
            */

            try
            {
                Console.WriteLine("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                double result = (double)Math.Sqrt(number);
                Console.WriteLine("The square root of this number is {0}", result);
            }

            catch (Exception)
            {
                Console.WriteLine("This is not a number.");
            }

            finally
            {
                Console.WriteLine("We love math!");
            }
        }
    }
}
