namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1
            int intVar = 42;
            double doubleVar = 42.42;
            float floatVar = 42.42F;
            char charVar = 'A';
            bool boolVar = true;
            string stringVar = "Hello and Cheese";

            Console.WriteLine(intVar);
            Console.WriteLine(doubleVar);
            Console.WriteLine(floatVar);
            Console.WriteLine(charVar);
            Console.WriteLine(boolVar);
            Console.WriteLine(stringVar);

            // Step 2
            double doubleValue = 9.78;
            int castedInt = (int)doubleValue;

            int intValue = 10;
            string stringFromInt = Convert.ToString(intValue);
            string stringFromBool = Convert.ToString(boolVar);

            Console.WriteLine(doubleValue);
            Console.WriteLine(castedInt);
            Console.WriteLine(stringFromInt);
            Console.WriteLine(stringFromBool);

            // Step 3
            Console.WriteLine("Enter your name:");
            string? userName = Console.ReadLine();
            userName = string.IsNullOrWhiteSpace(userName) ? "Unknown" : userName;

            Console.WriteLine("Enter your age:");
            string? ageInput = Console.ReadLine();
            int userAge;
            while (!int.TryParse(ageInput, out userAge))
            {
                Console.WriteLine("Invalid input. Please enter a valid age:");
                ageInput = Console.ReadLine();
            }

            Console.WriteLine(userName);
            Console.WriteLine(userAge);

            // Step 4
            int num1 = 10;
            int num2 = 20;

            Console.WriteLine(num1 + 10);
            Console.WriteLine(num2 - 2);
            Console.WriteLine(num1 * 3);
            Console.WriteLine(num2 / 2);
            Console.WriteLine(num2 % 2);

            // Step 5
            float floatVal = 1.123456789F;
            double doubleVal = 1.123456789;

            Console.WriteLine(floatVal);
            Console.WriteLine(doubleVal);

            // Part 6: Increment and Decrement
            int incrementDecrementVar = 10;
            incrementDecrementVar++;
            Console.WriteLine(incrementDecrementVar);
            incrementDecrementVar--;
            Console.WriteLine(incrementDecrementVar);
        }
    }
}