using System;

namespace TaskImplementation.Tasks
{
    public static class DisplayNumbersWithGap
    {
        public static void Execute()
        {
            Console.WriteLine("Numbers from 100 to 5 with a decrement of 3:");

            for (int i = 100; i >= 5; i -= 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
