using System;
using System.Collections.Generic;

namespace Dividing_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int i = 0,
                divisor = 1;
            bool error = false;
            List<int> divident = new List<int>();
            List<double> quotient = new List<double>();
            List<int> remainder = new List<int>();
            //list
            divident.Add(41);
            divident.Add(13);
            divident.Add(7564);
            divident.Add(69);
            divident.Add(420);
            divident.Add(69420);


            Console.WriteLine("Enter a non decimal value");
            try
            {
                divisor = Convert.ToInt32(Console.ReadLine());
                foreach (int count in divident)
                {
                    quotient.Add(count / divisor);
                    remainder.Add(count % divisor);
                }
                
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Please enter a non-zero integer value..");
                Console.WriteLine("Examples: 1, 2, 3, 4, 5...");
                Console.WriteLine("\nPress any key and enter to continue");
                Console.ReadLine();
                error = true;
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a integer value..");
                Console.WriteLine("Examples: 1, 2, 3, 4, 5...");
                Console.WriteLine("\nPress any key and enter to continue");
                Console.ReadLine();
                error = true;
            }
            // Output
            if (!error)
            {
                Console.WriteLine("\nResults");
                foreach (double count in quotient)
                {
                    Console.WriteLine(divident[i] + " / " + divisor + " = " + count + " with a remainder of " + remainder[i]);
                    i++;
                }
            }
            
            
        }
    }
}
