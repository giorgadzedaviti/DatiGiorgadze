using System;

class Program
{
    //entry point of the program it accepts an array of strings named args as a parameter
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the character array: ");
        if (int.TryParse(Console.ReadLine(), out int arraySize) && arraySize > 0)
        {

            //It passes the user-provided array size as an argument.
            char[] charArray = GetUserFilledCharArray(arraySize);

            //this foreach method prints every character from the array
            foreach (char element in charArray)
            {
                Console.WriteLine(element);
            }
            //method to get the character the user wants to search for.
            char searchChar = GetSearchCharacter();

            //method, which counts the occurrences of the specified character
            //(searchChar) in the charArray. The count is stored in the charCount variable.
            int charCount = CountCharacterOccurrences(charArray, searchChar);

            //method to print the result of the character count,
            //indicating how many times the character was found in the array.
            PrintCharacterCount(searchChar, charCount);
        }
        else
        {
            Console.WriteLine("Invalid input for the array size.");
        }
    }
    static char[] GetUserFilledCharArray(int size)
    {
        char[] array = new char[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            char userInput = Console.ReadKey().KeyChar; // Read a single character from the console.
            Console.WriteLine(); // Move to the next line.

            array[i] = userInput;
        }

        return array;
    }
    static char GetSearchCharacter()
    {
        Console.Write("Enter the character to search for: ");
        return Console.ReadKey().KeyChar;
    }
    static int CountCharacterOccurrences(char[] array, char searchChar)
    {
        int count = 0;

        foreach (char element in array)
        {
            if (element == searchChar)
            {
                count++;
            }
        }
        return count;
    }

    static void PrintCharacterCount(char searchChar, int charCount)
    {
        Console.WriteLine($"Character '{searchChar}' has been encountered {charCount} times.");
    }
}
