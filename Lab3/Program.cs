using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Comparison and Logical Operators
            int a = 10, b = 5, c = 15;
            
            Console.WriteLine($"a > b: {a > b}");
            Console.WriteLine($"a < c: {a < c}");
            Console.WriteLine($"a > b && a > c: {a > b && a > c}");
            Console.WriteLine($"a > b || a > c: {a > b || a > c}");
            Console.WriteLine();

            // Part 2: Boolean Logic
            bool isRaining = true;
            bool haveUmbrella = false;
            
            if (isRaining && !haveUmbrella)
            {
                Console.WriteLine("Take an umbrella!");
            }
            else
            {
                Console.WriteLine("You're good to go!");
            }
            Console.WriteLine();

            // Part 3: Conditional Logic - Movie Ticket Pricing
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            
            if (age < 5)
            {
                Console.WriteLine("Ticket is free!");
            }
            else if (age >= 5 && age <= 12)
            {
                Console.WriteLine("Child ticket: $5");
            }
            else if (age >= 13 && age <= 64)
            {
                Console.WriteLine("Standard ticket: $10");
            }
            else
            {
                Console.WriteLine("Senior ticket: $6");
            }
            Console.WriteLine();

            // Part 4: Using a switch Statement
            Console.WriteLine("Part 4: Days of the Week");
            Console.Write("Enter a day number (1-7): ");
            int dayNumber = int.Parse(Console.ReadLine());
            
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }
        }
    }
}