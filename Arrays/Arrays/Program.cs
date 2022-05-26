using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringOption = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            int[] intOption = {23, 128, 231, 482, 12, 47, 5};
            int response = 6;
            // Create a list of parts.
            List<string> parts = new List<string>();

            // Add parts to the list.
            parts.Add("crank arm");
            parts.Add("chain ring");
            parts.Add("regular seat");
            parts.Add("banana seat");
            // String Array
            do
            {
                Console.WriteLine("choose an index number from 1 to " + stringOption.Length);
                response = Convert.ToInt32(Console.ReadLine());
                switch (response)
                {
                    case 1:
                        Console.WriteLine(stringOption[0]);
                        break;
                    case 2:
                        Console.WriteLine(stringOption[1]);
                        break;
                    case 3:
                        Console.WriteLine(stringOption[2]);
                        break;
                    case 4:
                        Console.WriteLine(stringOption[3]);
                        break;
                    case 5:
                        Console.WriteLine(stringOption[4]);
                        break;
                    case 6:
                        Console.WriteLine(stringOption[5]);
                        break;
                    case 7:
                        Console.WriteLine(stringOption[6]);
                        break;
                    default:
                        Console.WriteLine("That option is not apart of the index");
                        break;
                }
            } while (response < 1 || response > stringOption.Length);
            // int array
            do
            {
                Console.WriteLine("choose an index number from 1 to " + intOption.Length);
                response = Convert.ToInt32(Console.ReadLine());
                switch (response)
                {
                    case 1:
                        Console.WriteLine(intOption[0]);
                        break;
                    case 2:
                        Console.WriteLine(intOption[1]);
                        break;
                    case 3:
                        Console.WriteLine(intOption[2]);
                        break;
                    case 4:
                        Console.WriteLine(intOption[3]);
                        break;
                    case 5:
                        Console.WriteLine(intOption[4]);
                        break;
                    case 6:
                        Console.WriteLine(intOption[5]);
                        break;
                    case 7:
                        Console.WriteLine(intOption[6]);
                        break;
                    default:
                        Console.WriteLine("That option is not apart of the index");
                        break;
                }
            } while (response < 1 || response > intOption.Length);
            do
            {
                Console.WriteLine("choose an index number from 1 to 4");
                response = Convert.ToInt32(Console.ReadLine());
                switch (response)
                {
                    case 1:
                        Console.WriteLine(parts[0]);
                        break;
                    case 2:
                        Console.WriteLine(parts[1]);
                        break;
                    case 3:
                        Console.WriteLine(parts[2]);
                        break;
                    case 4:
                        Console.WriteLine(parts[3]);
                        break;
                    default:
                        Console.WriteLine("That option is not apart of the index");
                        break;
                }
            } while (response < 1 || response > 4);


        }
    }
}
