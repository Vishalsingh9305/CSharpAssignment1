using System;

namespace TaskImplementation.Tasks
{
    public static class ArithmeticOperationsUserChoice
    {
        public static void Execute()
        {
            Console.WriteLine("Enter two numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Result: {a} + {b} = {a + b}");
                    break;
                case "2":
                    Console.WriteLine($"Result: {a} - {b} = {a - b}");
                    break;
                case "3":
                    Console.WriteLine($"Result: {a} * {b} = {a * b}");
                    break;
                case "4":
                    if (b != 0)
                        Console.WriteLine($"Result: {a} / {b} = {a / (double)b}");
                    else
                        Console.WriteLine("Cannot divide by zero.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
