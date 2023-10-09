
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a 3x3 matrix:");

        double[,] matrix = new double[3, 5];

        // Input elements into the first 3 columns of the 3x5 matrix
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write($"Enter element at row {row + 1}, column {col + 1}: ");
                if (double.TryParse(Console.ReadLine(), out double element))
                {
                    matrix[row, col] = element;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    col--; // Retry the same column
                }
            }
        }

        // Add the last two columns to the 3x5 matrix
        for (int row = 0; row < 3; row++)
        {
            matrix[row, 3] = matrix[row, 1];
            matrix[row, 4] = matrix[row, 2];
        }

        //function that Calculates the determinant using the different formula
        double determinant = (matrix[0, 0] * matrix[1, 1] * matrix[2, 2]) +
                             (matrix[0, 1] * matrix[1, 2] * matrix[2, 3]) +
                             (matrix[0, 2] * matrix[1, 3] * matrix[2, 4]) -
                             (matrix[0, 4] * matrix[1, 3] * matrix[2, 2]) -
                             (matrix[0, 3] * matrix[1, 2] * matrix[2, 1]) -
                             (matrix[0, 2] * matrix[1, 1] * matrix[2, 0]);

        // Print the entered matrix with added columns
        Console.WriteLine("Entered 3x3 matrix with added columns:");
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }

        // Print the determinant
        Console.WriteLine("Determinant: " + determinant);
        Console.ReadLine(); // Pause execution to see the result
    }
}
