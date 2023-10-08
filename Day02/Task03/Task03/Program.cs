using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a 2x2 matrix:");
        double[,] matrix = new double[2, 2];

        // Input elements into the 2x2 matrix
        for (int row = 0; row < 2; row++)
        {
            for (int col = 0; col < 2; col++)
            {
                Console.Write($"Enter element at row {row + 1}, column {col + 1}: ");
                matrix[row, col] = double.Parse(Console.ReadLine());
            }
        }

        // Calculate the determinant of the 2x2 matrix
        double determinant = Calculate2x2Determinant(matrix);

        // Print the entered matrix
        Console.WriteLine("Entered 2x2 matrix:");
        for (int row = 0; row < 2; row++)
        {
            for (int col = 0; col < 2; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }

        // Print the determinant
        Console.WriteLine("Determinant of the 2x2 matrix: " + determinant);

        Console.ReadLine(); // Pause execution to see the result
    }

    // Calculate the determinant of a 2x2 matrix
    static double Calculate2x2Determinant(double[,] matrix)
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }
}
