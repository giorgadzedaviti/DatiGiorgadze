using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the array : ");

        //to convert string data type into number
        int N = int.Parse(Console.ReadLine());

        //array that can hold a collection of integer values
        int[] array = new int[N];

        // Input elements into the array
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        // sort the array using the Insertion Sort function
        InsertionSort(array);

        // print the sorted array
        Console.WriteLine("Sorted array:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        Console.ReadLine();
    }

    // Insertion Sort algorithm implementation
    static void InsertionSort(int[] arr)
    {
        int N = arr.Length; // get the length of the input array

        for (int i = 1; i < N; i++)
        {
            int key = arr[i]; // store the current element to be compared
            int j = i - 1; //// initialize a variable to the index before the current element

            // Move elements of arr[0..i-1] that are greater than key
            // to one position ahead of their current position
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j]; // shift the larger element one position to the right
                j--;  // move to the previous element on the left
            }

            arr[j + 1] = key;// place the key in its correct sorted position
        }
    }
}
