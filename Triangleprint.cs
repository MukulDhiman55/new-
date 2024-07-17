
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the height of  triangle:");
        if (int.TryParse(Console.ReadLine(), out int height))
        {
            if (height > 0)
            {
                PrintTriangle(height);
            }
            else
            {
                Console.WriteLine("Height must be positive.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static void PrintTriangle(int height)
    {
        for (int i = 1; i <= height; i++)
        {
           
            for (int j = 1; j <= height - i; j++)
            {
                Console.Write(" ");
            }

           
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine(); 
        }
    }
}
