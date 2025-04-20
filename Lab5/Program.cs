using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1();

            Problem2();

            Problem3();

            Problem4();

            Problem5();
        }

        static void Problem1()
        {
            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

            foreach (string season in seasons)
            {
                Console.WriteLine($"Season: {season}");
            }
        }

        static void Problem2()
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.Write("Enter a number (1-7): ");
            if (int.TryParse(Console.ReadLine(), out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine($"That day is: {days[dayNumber - 1]}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            }
        }

        static void Problem3()
        {
            string[] books = { "The Hobbit", "Charlotte's Web", "1984" };
            string[] authors = { "J.R.R. Tolkien", "E.B. White", "George Orwell" };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Book {i + 1}: {books[i]} by {authors[i]}");
            }
        }

        static void Problem4()
        {
            int[] temperatures = { 65, 72, 78, 70, 68 };

            Array.Sort(temperatures);
            Console.WriteLine("Sorted Temperatures: " + string.Join(" ", temperatures));
            Console.WriteLine($"Highest Temperature: {temperatures[temperatures.Length - 1]}");
            Console.WriteLine($"Lowest Temperature: {temperatures[0]}");
        }

        static void Problem5()
        {
            int[] countdown = { 5, 4, 3, 2, 1 };

            Array.Reverse(countdown);
            Console.Write("Countdown: ");
            for (int i = 0; i < countdown.Length; i++)
            {
                Console.Write(countdown[i] + " ");
            }
            Console.WriteLine();
        }
    }
}