using System;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1HourRate,
                p1HourWork,
                p2HourRate,
                p2HourWork;
            double weeksPerYear = 52.18,
                p1Annual,
                p2Annual;
            bool p1_V_p2;
            Console.WriteLine("Anonymous Income Comparison Program\n");
            // Person 1
            Console.WriteLine("---Person 1---");
            Console.WriteLine("Hourly Rate");
            p1HourRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            p1HourWork = Convert.ToInt32(Console.ReadLine());
            // Person 2
            Console.WriteLine("\n---Person 2---");
            Console.WriteLine("Hourly Rate");
            p2HourRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            p2HourWork = Convert.ToInt32(Console.ReadLine());

            // Math

            p1Annual = (p1HourRate * p1HourWork) * weeksPerYear;
            p2Annual = (p2HourRate * p2HourWork) * weeksPerYear;
            p1_V_p2 = p1Annual > p2Annual;
            // Results
            Console.WriteLine("Annual salary of Person 1:\n" + p1Annual);
            Console.WriteLine("Annual salary of Person 2:\n" + p2Annual);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(p1_V_p2);
        }
    }
}
