using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("DCIT 318: Programming II Assignment 1");
        Console.WriteLine("=====================================");
        Console.WriteLine("Select a program to run:");
        Console.WriteLine("1. Grade Calculator");
        Console.WriteLine("2. Ticket Price Calculator");
        Console.WriteLine("3. Triangle Type Identifier");
        Console.WriteLine("4. Exit");
        
        while (true)
        {
            Console.Write("\nEnter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GradeCalculator.Run();
                    break;
                case "2":
                    TicketPriceCalculator.Run();
                    break;
                case "3":
                    TriangleTypeIdentifier.Run();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");
                    break;
            }
        }
    }
}
