using System;

namespace TaskImplementation.Tasks
{
    public static class DisplayOddNumbers
    {
        public static void Execute(int n)
        {
            Console.WriteLine($"Odd numbers from 1 to {n}:");

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
