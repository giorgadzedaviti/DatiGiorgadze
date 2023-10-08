using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the first array (N): ");
        int N = int.Parse(Console.ReadLine());

        string[] firstArray = new string[N];

        // Input elements into the first array
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Enter element {i + 1} for the first array: ");
            firstArray[i] = Console.ReadLine();
        }

        Console.Write("Enter the size of the second array: ");
        int M = int.Parse(Console.ReadLine());

        string[] secondArray = new string[M];

        // Input elements into the second array
        for (int i = 0; i < M; i++)
        {
            Console.Write($"Enter element {i + 1} for the second array: ");
            secondArray[i] = Console.ReadLine();
        }

        // Combine the two arrays
        string[] combinedArray = new string[N + M];
        int index = 0;

        for (int i = 0; i < N; i++)
        {
            combinedArray[index++] = firstArray[i];
            if (i < M)
            {
                combinedArray[index++] = secondArray[i];
            }
        }

        // Print sum of arrays 
        Console.WriteLine("Concatenated array:");
        foreach (string element in combinedArray)
        {
            Console.WriteLine(element);
        }

        Console.ReadLine(); // Pause execution to see the result
    }
}
