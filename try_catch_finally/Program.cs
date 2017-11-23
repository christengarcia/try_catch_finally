using System;

namespace try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerator, denominator;

            Console.Write("Please enter the numerator: ");
            numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the denominator: ");
            denominator = Convert.ToInt32(Console.ReadLine());

            // try-catch-finally statement controls how the 
            // program proceeds when an error occurs. 
            try{
                Console.WriteLine("The result is {0}.", numerator/denominator);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("---- End of Error Handling Example ----");
            }
        }
    }
}
