using System;

namespace TaskImplementation.Tasks
{
    public static class DeclareAndDisplayIntegersOneLine
    {
        public static void Execute()
        {
            int a = 10, b = 20, c = 30;

            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
        }
    }
}
