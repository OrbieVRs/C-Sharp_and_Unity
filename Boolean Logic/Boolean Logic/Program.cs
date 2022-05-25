using System;

namespace Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            int age,
                tickets;
            char r_DUI;
            bool DUI = false,
                Qualification;
            
            Console.WriteLine("~~~ Car Insurance ~~~");
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? (y/n)");
            r_DUI = Convert.ToChar(Console.ReadLine());
            if (r_DUI == 'y')
                DUI = true;
            else if (r_DUI == 'n')
                DUI = false;
            Console.WriteLine("How many speeding tickets do you have?");
            tickets = Convert.ToInt32(Console.ReadLine());

            Qualification = (age >= 15) && (!DUI) && (tickets < 3);
            // Results
            if (Qualification)
            {
                Console.WriteLine("You Qualify");
            }else
            {
                Console.WriteLine("You don't Qualify");
            }
        }
    }
}
