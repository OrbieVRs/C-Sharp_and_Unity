using System;
using System.Collections.Generic;

namespace _6_part_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int j = 0,
                intTemp;
            string[] adLib =
            {
                "Women are",
                "Guys are",
                "Dogs are",
                "You are",
                "I am"
            };
            string temp = "";
            string[] groceryList =
            {
                "Milk",
                "Eggs",
                "Bacon",
                "Cheese",
                "Cookies",
                "Cereal",
                "Snacks",
                "Candy",
                "Ice Cream"
            };
            
            List<int> grades = new List<int>(); 
            bool defaultCheck = false;

            // List Body
            grades.Add(76);
            grades.Add(88);
            grades.Add(69);
            grades.Add(33);
            grades.Add(100);
            grades.Add(99);
            grades.Add(88);
            grades.Add(82);
            grades.Add(75);
            grades.Add(69);
            grades.Add(24);

            // Body
            Console.WriteLine("Say a verb");
            temp = Console.ReadLine();
            for (int i = 0; i < adLib.Length; i++) 
            {
                adLib[i] = adLib[i] + temp;
                Console.WriteLine(i + ". " + adLib[i]);
            }
            /* infinite loop
            while (j < 10);
            {
                j++;
            }
            */
            while (j < 10)
            {
                j++;
            }
            
            // grocery
            Console.WriteLine("Type grocery items");
            temp = Console.ReadLine();
            for (int i = 0; i < groceryList.Length; i++)
            {
                if (temp == groceryList[i])
                {
                    defaultCheck = true;
                    Console.WriteLine(groceryList[i] + " is " + i + "in the index");
                }
            }
            if (!defaultCheck)
            {
                Console.WriteLine(temp + " is not in the index");
            }

            // Grades
            defaultCheck = false;
            Console.WriteLine("Type a number");
            intTemp = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < grades.Count; i++)
            {
                if (intTemp == grades[i])
                {
                    defaultCheck = true;
                    Console.WriteLine(grades[i] + " is " + i + "in the index");
                }
            }
            if (!defaultCheck)
            {
                Console.WriteLine(intTemp + " is not in the index");
            }

            
            // Part 6
            List<string> animals = new List<string>();
            animals.Add("Dog");
            animals.Add("Cat");
            animals.Add("Wolf");
            animals.Add("Penguin");
            animals.Add("Fox");
            animals.Add("Dragon");
            animals.Add("Cat");
            animals.Add("Snake");
            animals.Add("Protogen");
            animals.Add("Pig");
            animals.Add("Lion");
            Console.WriteLine("");
            foreach (string count in animals) 
            {
                int i = 0;
                bool duplicateCheck = false;
                while (i <animals.Count)
                {
                    if(count == animals[i])
                    {
                        duplicateCheck = true;
                    }
                }
                if (duplicateCheck)
                {
                    Console.WriteLine(count);
                }
            }
        }
    }
}
