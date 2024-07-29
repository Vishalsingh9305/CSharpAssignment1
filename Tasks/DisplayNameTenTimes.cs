using System;

namespace TaskImplementation.Tasks
{
    public static class DisplayNameTenTimes
    {
        public static void Execute()
        {
            string name = "vishal singh"; 

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(name);
            }
        }
    }
}
