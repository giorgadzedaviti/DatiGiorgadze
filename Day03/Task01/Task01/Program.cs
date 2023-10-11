using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements you want to input: ");
        if (int.TryParse(Console.ReadLine(), out int numElements) && numElements > 0)
        {
            //creates an integer array named numbers with a
            //size equal to the number of elements provided by the user.
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
                Console.WriteLine($"Index {i}: {numbers[i]}");

                if (i == 2) // Check if the current index is 2.
                {
                    int element = numbers[i];
                    int digitSum = CalculateDigitSum(element);
                    Console.WriteLine($"Sum of digits: {digitSum}");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input for the array size.");
        }
    }

    static int CalculateDigitSum(int number)
    {
        // Convert the number to a string.
        string numberAsString = number.ToString();

        int sum = 0;

        // Iterate through each character (digit) in the string representation of the number.
        foreach (char digitChar in numberAsString)
        {
            // Convert the character back to an integer and add it to the sum.
            int digit = int.Parse(digitChar.ToString());
            sum += digit;
        }

        return sum;
    }

}
