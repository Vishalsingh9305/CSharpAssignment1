using System;

namespace TaskImplementation.Tasks
{
    public static class DeclareAndDisplayIntegersSeparateLines
    {
        public static void Execute()
        {
            // Declare and initialize integer variables
            int a = 10;
            int b = 20;
            int c = 30;

            // Display each variable on a separate line
            Console.WriteLine($"Value of a: {a}");
            Console.WriteLine($"Value of b: {b}");
            Console.WriteLine($"Value of c: {c}");
        }
    }
}
