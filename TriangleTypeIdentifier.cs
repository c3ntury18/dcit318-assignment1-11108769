using System;

public class TriangleTypeIdentifier
{
    public static void Run()
    {
        Console.WriteLine("\n--- Triangle Type Identifier ---");
        Console.Write("Enter the first side: ");
        string input1 = Console.ReadLine();
        Console.Write("Enter the second side: ");
        string input2 = Console.ReadLine();
        Console.Write("Enter the third side: ");
        string input3 = Console.ReadLine();

        double side1, side2, side3;

        if (double.TryParse(input1, out side1) && 
            double.TryParse(input2, out side2) && 
            double.TryParse(input3, out side3))
        {
            if (side1 > 0 && side2 > 0 && side3 > 0)
            {
                // Check if it forms a valid triangle
                if ((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1))
                {
                    if (side1 == side2 && side2 == side3)
                    {
                        Console.WriteLine("Triangle Type: Equilateral");
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        Console.WriteLine("Triangle Type: Isosceles");
                    }
                    else
                    {
                        Console.WriteLine("Triangle Type: Scalene");
                    }
                }
                else
                {
                    Console.WriteLine("The given sides do not form a valid triangle.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. All sides must be positive numbers.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numerical values for all sides.");
        }
    }
}
