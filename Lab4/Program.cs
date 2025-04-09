namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple For Loop (1 to 10)");
            Problem1();
            Console.WriteLine();

            Console.WriteLine("Even Numbers from 1 to 20");
            Problem2();
            Console.WriteLine();

            Console.WriteLine("While Loop Countdown (5 to 1)");
            Problem3();
            Console.WriteLine();

            Console.WriteLine("Do/While User Input (Number > 100)");
            Problem4();
            Console.WriteLine();

            Console.WriteLine("Multiples of 10 from 10 to 1000");
            Problem5();
            Console.WriteLine();

            Console.WriteLine("Pattern Printer");
            Problem6();
        }

        static void Problem1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Problem2()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Problem3()
        {
            int count = 5;
            while (count >= 1)
            {
                Console.WriteLine(count);
                count--;
            }
        }

        static void Problem4()
        {
            int number;
            do
            {
                Console.Write("Enter a number greater than 100: ");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number <= 100);
            
            Console.WriteLine($"You entered: {number}");
        }

        static void Problem5()
        {
            int num = 10;
            while (num <= 1000)
            {
                Console.WriteLine(num);
                num += 10;
            }
        }

        static void Problem6()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}