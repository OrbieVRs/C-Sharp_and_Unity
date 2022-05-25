using System;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            string r_Experiences,
                r_feedback,
                r_name,
                r_course,
                r_bool;
            int r_hours,
                r_page;

            
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine("\n\n");
            Console.WriteLine("What is your name ?");
            //response
            r_name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            //Response
            r_course = Console.ReadLine();
            Console.WriteLine("What page number?");
            //Response
            r_page = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            //Response
            r_bool = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            r_Experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            r_feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            r_hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            //Output
            Console.WriteLine("The results are:");
            Console.WriteLine("Name: " + r_name);
            Console.WriteLine("Page: " + r_page);
            Console.WriteLine("Help: " + r_bool);
            Console.WriteLine("XP: " + r_Experiences);
            Console.WriteLine("Feed: " + r_feedback);
            Console.WriteLine("Hours: " + r_hours);
        }
    }
}
