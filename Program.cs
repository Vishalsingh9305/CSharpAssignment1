using System;
using TaskImplementation.Tasks; // Ensure to include the namespace where your tasks are defined

namespace TaskImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Task Implementation App!");

            while (true)
            {
                Console.WriteLine("Choose a task to execute:");
                Console.WriteLine("1. Display Hello Message");
                Console.WriteLine("2. Arithmetic Operations");
                Console.WriteLine("3. Arithmetic Operations based on User Choice");
                Console.WriteLine("4. Display Your Name 10 Times");
                Console.WriteLine("5. Display Even Numbers");
                Console.WriteLine("6. Display Odd Numbers");
                Console.WriteLine("7. Display Multiplication Table");
                Console.WriteLine("8. Display Numbers with Gap");
                Console.WriteLine("9. Declare and Display Integer Variables (One Line)");
                Console.WriteLine("10. Declare and Display Integer Variables");

                Console.WriteLine("0. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        HelloMessage.Execute();
                        break;
                    case "2":
                        ArithmeticOperations.Execute();
                        break;
                    case "3":
                        ArithmeticOperationsUserChoice.Execute();
                        break;
                    case "4":
                        DisplayNameTenTimes.Execute();
                        break;
                    case "5":
                        Console.WriteLine("Enter a number:");
                        int nEven = int.Parse(Console.ReadLine());
                        DisplayEvenNumbers.Execute(nEven);
                        break;
                    case "6":
                        Console.WriteLine("Enter a number:");
                        int nOdd = int.Parse(Console.ReadLine());
                        DisplayOddNumbers.Execute(nOdd);
                        break;
                    case "7":
                        Console.WriteLine("Enter a number:");
                        int number = int.Parse(Console.ReadLine());
                        DisplayMultiplicationTable.Execute(number);
                        break;
                    case "8":
                        DisplayNumbersWithGap.Execute();
                        break;
                    case "9":
                        DeclareAndDisplayIntegersOneLine.Execute();
                        break;
                    case "10":
                        DeclareAndDisplayIntegersSeparateLines.Execute();
                        break;
                    case "0":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
