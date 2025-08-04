using System;

public class GradeCalculator
{
    public static void Run()
    {
        Console.WriteLine("\n--- Grade Calculator ---");
        Console.Write("Enter numerical grade (0-100): ");
        string input = Console.ReadLine();
        int grade;

        if (int.TryParse(input, out grade))
        {
            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("Letter Grade: A");
            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine("Letter Grade: B");
            }
            else if (grade >= 70 && grade <= 79)
            {
                Console.WriteLine("Letter Grade: C");
            }
            else if (grade >= 60 && grade <= 69)
            {
                Console.WriteLine("Letter Grade: D");
            }
            else if (grade >= 0 && grade < 60)
            {
                Console.WriteLine("Letter Grade: F");
            }
            else
            {
                Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numerical grade.");
        }
    }
}
