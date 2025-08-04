using System;

public class TicketPriceCalculator
{
    public static void Run()
    {
        Console.WriteLine("\n--- Ticket Price Calculator ---");
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();
        int age;

        if (int.TryParse(input, out age))
        {
            if (age >= 0)
            {
                if (age <= 12 || age >= 65)
                {
                    Console.WriteLine("Ticket Price: GHC7 (Discounted)");
                }
                else
                {
                    Console.WriteLine("Ticket Price: GHC10 (Regular)");
                }
            }
            else
            {
                Console.WriteLine("Invalid age. Please enter a positive number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}
