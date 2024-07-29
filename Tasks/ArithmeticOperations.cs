using System;

namespace TaskImplementation.Tasks
{
    public static class ArithmeticOperations
    {
        public static void Execute()
        {
            int a = 10;
            int b = 5;

            Console.WriteLine($"Addition: {a} + {b} = {a + b}");
            Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
            Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");

            if (b != 0)
                Console.WriteLine($"Division: {a} / {b} = {a / (double)b}");
            else
                Console.WriteLine("Cannot divide by zero.");
        }
    }
}
