using System;

namespace TaskImplementation.Tasks
{
    public static class DisplayMultiplicationTable
    {
        public static void Execute(int number)
        {
            Console.WriteLine($"Multiplication table of {number}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}
