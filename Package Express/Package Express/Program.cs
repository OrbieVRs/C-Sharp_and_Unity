using System;
using System.Globalization;

namespace Package_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            int packageWeight,
                packageWidth,
                packageHeight,
                packageLength,
                packageDimension;
            double packageTotal;
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");
            Console.WriteLine("Please enter the package weight:");
            packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                packageLength = Convert.ToInt32(Console.ReadLine());
                packageDimension = packageWidth + packageLength + packageHeight;
                if (packageDimension > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    packageTotal = ((packageHeight * packageWidth * packageLength) * packageWeight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: " + packageTotal.ToString("C", CultureInfo.CurrentCulture));
                }
            }
        }
    }
}
