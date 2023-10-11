using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements you want to input: ");
        if (int.TryParse(Console.ReadLine(), out int numElements) && numElements > 0)
        {
            int[] numbers = new int[numElements];

            for (int i = 0; i < numElements; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out numbers[i]) == false)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--;
                }
            }

            Console.WriteLine("The array you entered:");
            for (int i = 0; i < numElements; i++)
            {
                Console.WriteLine($" {i + 1}: {numbers[i]}");
            }
        }
    }
}
